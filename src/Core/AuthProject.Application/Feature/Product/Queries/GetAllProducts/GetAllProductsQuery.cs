using AuthProject.Application.Wrappers;
using MediatR;

namespace AuthProject.Application.Feature.Product.Queries.GetAllProducts;

public class GetAllProductsQuery : IRequest<ApiResponse<IEnumerable<GetAllProductsQueryResponse>>>
{
}
