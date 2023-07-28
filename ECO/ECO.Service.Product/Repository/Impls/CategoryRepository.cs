using ECO.Service.Product.Enitites;
using Infrastructure.Repository;

namespace ECO.Service.Product.Repository.Impls
{
    public class CategoryRepository : EntityRepository<Category, int, ApplicationDBContext> , ICategoryRepository
    {
        public CategoryRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
