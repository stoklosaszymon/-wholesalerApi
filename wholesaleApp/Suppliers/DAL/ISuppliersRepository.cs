using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wholesaleApp.Suppliers.DAL
{
    public interface ISuppliersRepository
    {
        IEnumerable<Suppliers> GetAll();
    }
}
