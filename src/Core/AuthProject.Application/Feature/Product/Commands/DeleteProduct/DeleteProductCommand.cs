using AuthProject.Application.Wrappers;
using MediatR;

namespace AuthProject.Application.Feature.Product.Commands.DeleteProduct;

public class DeleteProductCommand : IRequest<ApiResponse<string>>
{
    public Guid Id { get; set; }
}
