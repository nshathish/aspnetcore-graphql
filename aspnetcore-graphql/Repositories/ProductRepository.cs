namespace Aspnetcore.Graphql.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Data;
    using Data.Entities;
    using Microsoft.EntityFrameworkCore;

    public class ProductRepository
    {
        private readonly SqliteDbContext _dbContext;

        public ProductRepository(SqliteDbContext dbContext)=> _dbContext = dbContext;

        public Task<List<Product>> GetAll()=> _dbContext.Products.ToListAsync();

        public Task<Product> GetOne(int id)=> _dbContext.Products.SingleAsync(p => p.Id == id);

    }
}