using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wholesaleApp.Suppliers.DAL;

namespace wholesaleApp.Suppliers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {

        private readonly ISuppliersRepository _supplierRepository;

        public SuppliersController(ISuppliersRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        [HttpGet]
        public IEnumerable<DAL.Suppliers>GetSuppliers()
        {
            return _supplierRepository.GetAll();
        }
    }
}
