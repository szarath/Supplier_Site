using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Supplier_Site.Models;
using Supplier_Site.Services;

namespace Supplier_Site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        // GET: api/Supplier
        [HttpGet]
        public ActionResult<IEnumerable<Supplier>> GetSuppliers()
        {
            var suppliers = _supplierService.GetAll();
            return Ok(suppliers);
        }

        // GET: api/Supplier/5
        [HttpGet("{id}")]
        public ActionResult<Supplier> GetSupplier(int id)
        {
            var supplier = _supplierService.GetById(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return supplier;
        }

        [HttpGet("name/{name}")]
        public ActionResult<IEnumerable<Supplier>> GetSupplierByName(string name)
        {
            var suppliers = _supplierService.SearchByName(name);

            if (suppliers == null)
            {
                return NotFound();
            }

            return Ok(suppliers);
        }

        // POST: api/Supplier
        [HttpPost]
        public IActionResult PostSupplier(Supplier supplier)
        {
            _supplierService.Add(supplier);
            return CreatedAtAction("GetSupplier", new { id = supplier.Id }, supplier);
        }

        // PUT: api/Supplier/5
        [HttpPut("{id}")]
        public IActionResult PutSupplier(int id, Supplier supplier)
        {
            if (id != supplier.Id)
            {
                return BadRequest();
            }

            _supplierService.Update(supplier);
            return NoContent();
        }

        // DELETE: api/Supplier/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSupplier(int id)
        {
            var existingSupplier = _supplierService.GetById(id);
            if (existingSupplier == null)
            {
                return NotFound();
            }

            _supplierService.Delete(id);
            return Ok(existingSupplier);
        }
    }
}
