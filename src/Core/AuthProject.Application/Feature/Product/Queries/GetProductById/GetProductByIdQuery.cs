using AuthProject.Application.Feature.Product.Queries.GetProductById;
using AuthProject.Application.Wrappers;
using MediatR;

namespace AuthProject.Application.Feature.Product.Queries.GetProductById;

public class GetProductByIdQuery : IRequest<ApiResponse<GetProductByIdQueryResponse>>
{
    public Guid Id { get; set; }
}
