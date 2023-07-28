using ECO.Service.Product.Enitites;
using Infrastructure.Repository;

namespace ECO.Service.Product.Repository.Impls
{
    public class ProductCategoryRepository : EntityRepository<ProductCategory, int, ApplicationDBContext>, IProductCategoryRepository
    {
        public ProductCategoryRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
