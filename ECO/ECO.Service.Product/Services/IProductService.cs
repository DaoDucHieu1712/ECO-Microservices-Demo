using ECO.Service.Product.DTOs.Product;
using Infrastructure.Interfaces;

namespace ECO.Service.Product.Services
{
    public interface IProductService : IEntityService<ProductDTO, ProductCommandDTO, int>
    {
    }
}
