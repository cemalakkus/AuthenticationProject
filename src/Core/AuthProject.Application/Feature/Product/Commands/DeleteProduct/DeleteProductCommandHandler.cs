using AutoMapper;
using AuthProject.Application.Exceptions;
using AuthProject.Application.Feature.Product.Commands.DeleteProduct;
using AuthProject.Application.Wrappers;
using MediatR;
using UnitOfWorkPattern.Application.Interfaces.UnitOfWork;

namespace AuthProject.Application.Feature.Product.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, ApiResponse<string>>
    {
        private readonly IUnitOfWork _uow;
        public DeleteProductCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ApiResponse<string>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _uow.Products.GetByIdAsync(request.Id);

            if (product is null) throw new ApiException($"Product Not Found.");

            await _uow.Products.DeleteAsync(product);

            await _uow.Complete();

            return new ApiResponse<string>(string.Empty, "Success");
        }
    }
}
