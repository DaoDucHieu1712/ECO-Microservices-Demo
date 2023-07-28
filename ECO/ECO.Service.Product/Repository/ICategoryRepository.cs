using ECO.Service.Product.Enitites;
using Infrastructure.Interfaces;

namespace ECO.Service.Product.Repository
{
    public interface ICategoryRepository : IEntityRepository<Category, int>
    {
    }
}
