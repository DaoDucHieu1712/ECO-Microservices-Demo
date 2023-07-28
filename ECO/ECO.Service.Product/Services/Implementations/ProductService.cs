using AutoMapper;
using ECO.Service.Product.DTOs.Product;
using ECO.Service.Product.Repository;
using Microsoft.EntityFrameworkCore;

namespace ECO.Service.Product.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task Add(ProductCommandDTO entity)
        {
            var p = mapper.Map<Enitites.Product>(entity);
            await productRepository.Add(p);
        }

        public async Task<ProductDTO> CreateAndGet(ProductCommandDTO entity)
        {
            var p = mapper.Map<Enitites.Product>(entity);
            return mapper.Map<ProductDTO>(await productRepository.CreateAndGetEntity(p));
        }

        public async Task<ProductDTO> FindById(int id)
        {
            return mapper.Map<ProductDTO>(await productRepository.FindSingle(x => x.Id == id));
        }

        public async Task<List<ProductDTO>> GetAll()
        {
            return mapper.Map<List<ProductDTO>>(await productRepository.FindAll().ToListAsync());
        }

        public async Task Remove(int id)
        {
           await productRepository.Remove(id);
        }

        public async Task Update(ProductCommandDTO entity)
        {
            var p = mapper.Map<Enitites.Product>(entity);
            await productRepository.Update(p, "CreatedAt");
        }
    }
}
