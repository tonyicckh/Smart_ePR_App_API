using System.DirectoryServices;

namespace ePR_App_Api.Data
{
    public class AdService
    {
        private readonly IConfiguration _config;
        private DirectoryEntry? _directoryEntry;

        public AdService(IConfiguration config)
        {
            _config = config;
        }

        private DirectoryEntry SearchRoot
        {
            get
            {
                if (_directoryEntry == null)
                {
                    string ldapPath = _config["ActiveDirectory:LdapPath"];
                    string serviceUser = _config["ActiveDirectory:ServiceUser"];
                    string servicePassword = _config["ActiveDirectory:ServicePassword"];

                    _directoryEntry = new DirectoryEntry(ldapPath, serviceUser, servicePassword, AuthenticationTypes.None);
                }
                return _directoryEntry;
            }
        }

        private SearchResult? FindUser(string login)
        {
            using (var searcher = new DirectorySearcher(SearchRoot))
            {
                // Can login with either email (mail) or userId (sAMAccountName)
                searcher.Filter = $"(&(objectClass=user)(|(mail={login})(sAMAccountName={login})))";
                searcher.PropertiesToLoad.Add("displayName");
                searcher.PropertiesToLoad.Add("sAMAccountName");
                searcher.PropertiesToLoad.Add("mail");

                return searcher.FindOne();
            }
        }

        public bool ValidateUser(string login, string password, out SearchResult? userResult)
        {
            userResult = FindUser(login);
            if (userResult == null) return false;

            try
            {
                // Always bind with Distinguished Name (DN)
                string userDn = userResult.Properties["distinguishedName"][0].ToString();

                using (var entry = new DirectoryEntry($"LDAP://{userDn}", login, password, AuthenticationTypes.Secure))
                {
                    var obj = entry.NativeObject; // Force bind
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
