using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wholesaleApp.Products
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public bool isAvailable { get; set; }
        public Guid Supplier_id { get; set; }
    }
}
