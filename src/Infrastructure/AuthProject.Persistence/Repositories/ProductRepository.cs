using AuthProject.Application.Interfaces.Repositories;
using AuthProject.Domain.Entities;
using AuthProject.Persistence.Context;

namespace AuthProject.Persistence.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext dbContext) : base(dbContext)
    {

    }
}
