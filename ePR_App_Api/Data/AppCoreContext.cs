using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Transactions;
using Azure.Core;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace ePR_App_Api.Data
{

    public class AppCoreContext
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public string papoConnectionString;
        public string srsoConnectionString;

        public AppCoreContext(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;

            papoConnectionString =  _configuration.GetConnectionString("DefaultConnection");
            srsoConnectionString = _configuration.GetConnectionString("SrSoConnection");
        }

        //public TransactionScope TransWithCommitted()
        //{
        //    return new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted });
        //}

        public DataTable GetTable(string sqlText, string connectionString)
        {
            DataTable table = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlText, connectionString))
            {
                adapter.Fill(table);
            }
            return table;
        }

        public string GetBaseUrl()
        {
            var request = _httpContextAccessor.HttpContext.Request;
            return $"{request.Scheme}://{request.Host}";
        }
    }

}
