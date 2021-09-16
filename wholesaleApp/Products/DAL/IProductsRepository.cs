using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wholesaleApp.Products
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetAll();
        void Add(Product product);
        void Delete(string productId);
    }
}
