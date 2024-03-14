using AuthProject.Application.Feature.Product.Commands.CreateProduct;
using AuthProject.Application.Feature.Product.Commands.DeleteProduct;
using AuthProject.Application.Feature.Product.Commands.UpdateProduct;
using AuthProject.Application.Feature.Product.Queries.GetAllProducts;
using AuthProject.Application.Feature.Product.Queries.GetPagedAllProducts;
using AuthProject.Application.Feature.Product.Queries.GetProductById;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : BaseApiController
{

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        return Ok(await Mediator.Send(new GetProductByIdQuery() { Id = id }));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await Mediator.Send(new GetAllProductsQuery()));
    }

    [HttpGet("GetPagedAll")]
    public async Task<IActionResult> GetPagedAll([FromQuery] GetPagedAllProductsQuery query)
    {
        return Ok(await Mediator.Send(query));
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create([FromHeader]string user,CreateProductCommand command)
    {
        return Ok(await Mediator.Send(command));
    }

    [HttpPut("{id}")]
    [Authorize]
    public async Task<IActionResult> Put(Guid id, UpdateProductCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        return Ok(await Mediator.Send(command));
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> Delete(Guid id)
    {
        return Ok(await Mediator.Send(new DeleteProductCommand { Id = id }));
    }
}
