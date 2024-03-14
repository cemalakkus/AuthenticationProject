using AuthProject.Application.Feature.Product.Commands.UpdateProduct;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthProject.Application.Feature.Product.Queries.GetProductById
{
    public class GetProductByIdQueryValidation : AbstractValidator<GetProductByIdQuery>
    {
        public GetProductByIdQueryValidation()
        {
            RuleFor(p => p.Id).NotEmpty().NotNull();
        }
    }
}
