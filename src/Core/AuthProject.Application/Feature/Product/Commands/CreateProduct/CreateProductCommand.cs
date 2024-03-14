﻿using AuthProject.Application.Wrappers;
using MediatR;

namespace AuthProject.Application.Feature.Product.Commands.CreateProduct;

public class CreateProductCommand : IRequest<ApiResponse<string>>
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
