using ECO.Service.Product.Enitites;
using Infrastructure.Interfaces;

namespace ECO.Service.Product.Repository
{
    public interface IProductCategoryRepository : IEntityRepository<ProductCategory, int>
    {
    }
}
