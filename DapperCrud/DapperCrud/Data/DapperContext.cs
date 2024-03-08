using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DapperCrud.Data
{
    public class DapperContext
    {
        private readonly IConfiguration configuration;
        private readonly string _connection;

        public DapperContext(IConfiguration configuration)
        {
            this.configuration = configuration;
            _connection = configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connection);
    }
}
