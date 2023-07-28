using ECO.Service.Product.Enitites;
using Infrastructure.Interfaces;

namespace ECO.Service.Product.Repository
{
    public interface IProductRepository : IEntityRepository<Enitites.Product, int>
    {
    }
}
