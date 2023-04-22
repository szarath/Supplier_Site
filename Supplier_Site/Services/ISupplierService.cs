using Supplier_Site.Models;

namespace Supplier_Site.Services
{
       public interface ISupplierService
    {
        IEnumerable<Supplier> GetAll();
        Supplier GetById(int id);
        void Add(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(int id);
        IEnumerable<Supplier> SearchByName(string name);
    }
}
