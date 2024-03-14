using AutoMapper;
using AuthProject.Application.Feature.Product.Commands.CreateProduct;
using AuthProject.Application.Feature.Product.Queries.GetAllProducts;
using AuthProject.Application.Feature.Product.Queries.GetPagedAllProducts;
using AuthProject.Application.Feature.Product.Queries.GetProductById;
using AuthProject.Domain.Entities;

namespace AuthProject.Application.Mappings;

public class GeneralMappings : Profile
{
    public GeneralMappings()
    {
        CreateMap<Product, GetPagedAllProductsQueryResponse>();
        CreateMap<Product, GetAllProductsQueryResponse>();
        CreateMap<Product, GetProductByIdQueryResponse>();
        CreateMap<Product, GetProductByIdQueryResponse>();
        CreateMap<CreateProductCommand, Product>();
    }
}
