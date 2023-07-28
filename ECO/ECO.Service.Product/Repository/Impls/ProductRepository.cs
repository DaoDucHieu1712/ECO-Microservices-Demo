using ECO.Service.Product.Enitites;
using Infrastructure.Repository;

namespace ECO.Service.Product.Repository.Impls
{
    public class ProductRepository : EntityRepository<Enitites.Product, int, ApplicationDBContext> , IProductRepository
    {
        public ProductRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
