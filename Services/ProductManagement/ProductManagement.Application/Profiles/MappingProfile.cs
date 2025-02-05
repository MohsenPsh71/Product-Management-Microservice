
using AutoMapper;
using ProductManagement.Application.Features.Products.Requests.Commands;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Profiles
{
    internal class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Product, UpdateProductsCommand>().ReverseMap();
            CreateMap<Product, CreateProductsCommand>().ReverseMap();
        }
    }
}
