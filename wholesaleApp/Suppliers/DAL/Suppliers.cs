using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wholesaleApp.Suppliers.DAL
{
    public class Suppliers
    {
       public string Name { get; set; }
       public Guid Id { get; set; }
       public string Address { get; set; }
       public string NIP { get; set; }
    }
}
