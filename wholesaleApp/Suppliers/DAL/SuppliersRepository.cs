using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace wholesaleApp.Suppliers.DAL
{
    public class SuppliersRepository : ISuppliersRepository
    {
        private readonly IDbConnection _dbConnection;
        public SuppliersRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
       
        public IEnumerable<Suppliers> GetAll()
        {
            const string sql = "SELECT \"Name\", \"Id\" FROM \"Suppliers\"";

            return _dbConnection.Query<Suppliers>(sql);
        }
    }
}
