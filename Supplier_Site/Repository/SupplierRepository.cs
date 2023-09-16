using Supplier_Site.Models;
using Supplier_Site.Repository;

namespace Supplier_Site.Repository
{
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        public SupplierRepository(SupplierDbContext context) : base(context)
        {
        }
    }
}
