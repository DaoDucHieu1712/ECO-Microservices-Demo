using AutoMapper;
using ECO.Service.Product.DTOs.Product;

namespace ECO.Service.Product.DTOs
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Enitites.Product, ProductDTO>().ReverseMap();
            CreateMap<Enitites.Product, ProductCommandDTO>().ReverseMap();
        }
    }
}
