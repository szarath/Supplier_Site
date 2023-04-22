using Supplier_Site.Models;
using Supplier_Site.Repository;

namespace Supplier_Site.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly SupplierRepository _repository;

        public SupplierService(SupplierRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _repository.GetAll();
        }

        public Supplier GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(Supplier supplier)
        {
            _repository.Add(supplier);
        }

        public void Update(Supplier supplier)
        {
            _repository.Update(supplier);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Supplier> SearchByName(string name)
        {
            return _repository.GetAll().Where(s => s.Name.Contains(name));
        }
    }
}
