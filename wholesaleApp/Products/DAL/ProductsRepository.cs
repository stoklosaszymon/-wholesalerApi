using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace wholesaleApp.Products
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductsRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Product> GetAll()
        {
            const string sql = "SELECT * FROM \"Products\"";

            return _dbConnection.Query<Product>(sql);
        }

        public void Add(Product product)
        {
            string sql = "INSERT INTO \"Products\"" +
                "(\"Id\", \"Name\", \"Price\", \"Amount\", \"isAvailable\", \"Supplier_id\") " +
                "VALUES (uuid_generate_v1(), @Name, @Price, @Amount, @isAvailable, @Supplier_id)";

            using (IDbConnection active = _dbConnection) 
            {
                active.Open();
                _dbConnection.Execute(sql, product);
            }
        }

        public void Delete(string id)
        {
            string sql = "DELETE FROM \"Products\" WHERE \"Id\" = @Id";

            using (IDbConnection active = _dbConnection) 
            {
                active.Open();
                _dbConnection.Execute(sql, new { Id = new Guid(id) });
            }
        }
    }
}
