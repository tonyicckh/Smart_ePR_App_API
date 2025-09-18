using System.DirectoryServices;
using Microsoft.Extensions.Configuration;

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

                    _directoryEntry = new DirectoryEntry(
                        ldapPath,
                        serviceUser,
                        servicePassword,
                        AuthenticationTypes.Secure
                    );
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
                searcher.PropertiesToLoad.Add("distinguishedName");

                return searcher.FindOne();
            }
        }

        public bool ValidateUser(string login, string password, out SearchResult? userResult)
        {
            userResult = FindUser(login);
            if (userResult == null) return false;

            try
            {
                string domain = _config["ActiveDirectory:Domain"]; // e.g. "SMART"

                // Make sure required properties exist
                if (userResult.Properties["sAMAccountName"].Count == 0 ||
                    userResult.Properties["distinguishedName"].Count == 0)
                    return false;

                string samAccountName = userResult.Properties["sAMAccountName"][0].ToString();
                string userDn = userResult.Properties["distinguishedName"][0].ToString();

                // 1️⃣ Try bind using distinguishedName + password
                try
                {
                    using var entry = new DirectoryEntry($"LDAP://{userDn}", samAccountName, password, AuthenticationTypes.Secure);
                    var obj = entry.NativeObject; // force bind
                    return true;
                }
                catch
                {
                    // 2️⃣ Fallback: DOMAIN\username + password
                    try
                    {
                        using var entry = new DirectoryEntry(
                            _config["ActiveDirectory:LdapPath"],
                            $"{domain}\\{samAccountName}",
                            password,
                            AuthenticationTypes.Secure);
                        var obj = entry.NativeObject;
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
