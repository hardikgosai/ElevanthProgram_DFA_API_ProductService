using AutoMapper;
using Getri_DFA_API_ProductService.DTO;
using Getri_DFA_API_ProductService.Models;

namespace Getri_DFA_API_ProductService.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateProductDTO, Product>();
            CreateMap<UpdateProductDTO, Product>();
            CreateMap<DeleteProductDTO, Product>();
        }
    }
}
