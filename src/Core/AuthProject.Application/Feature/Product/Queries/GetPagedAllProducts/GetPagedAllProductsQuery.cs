using AuthProject.Application.Parameters;
using AuthProject.Application.Wrappers;
using MediatR;

namespace AuthProject.Application.Feature.Product.Queries.GetPagedAllProducts;

public class GetPagedAllProductsQuery : RequestParameters, IRequest<PagedResponse<IEnumerable<GetPagedAllProductsQueryResponse>>>
{
}
