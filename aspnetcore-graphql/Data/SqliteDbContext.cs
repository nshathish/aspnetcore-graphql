namespace Aspnetcore.Graphql.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class SqliteDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }

        public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
        {
        }

    }
}