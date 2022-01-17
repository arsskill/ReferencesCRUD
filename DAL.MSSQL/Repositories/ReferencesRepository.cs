using Application.DTO_s.Lookup;
using Application.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MSSQL.Repositories
{
    public class ReferencesRepository : IReferencesRepository
    {
        private string connectionstring;
        public ReferencesRepository()
        {
            connectionstring = @"User ID=sa;password=123;Initial Catalog=Testing; Data Source=DESKTOP-TAT0UU1\Arseny;Connection Timeout=100000;";
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionstring);
            }
        }


        private readonly ReferencesRepository referencesRepository;
        public async Task<IEnumerable<ReferencesDTO>> GetReferencesAsync()
        {
            var query =
                @"SELECT * FROM [standart_dev].[dbo].[References]";
            using var connection = new SqlConnection(connectionstring);
            var services = await connection.QueryAsync<ReferencesDTO>(query);
            return services;
        }
        public async Task<IEnumerable<ReferencesDTO>> GetByNameAsync(string name)
        {
            var query =
                @"SELECT * FROM [standart_dev].[dbo].[References] Where name Like '@name'";
            using var connection = new SqlConnection(connectionstring);
            var services = await connection.QueryAsync<ReferencesDTO>(query, new { name = name });
            return services;
        }
        public async Task<IEnumerable<ReferencesDTO>> GetByOrderAsync()
        {
            var query =
                @"SELECT * FROM [standart_dev].[dbo].[References] Order By name";
            using var connection = new SqlConnection(connectionstring);
            var services = await connection.QueryAsync<ReferencesDTO>(query);
            return services;
        }

    }
}
