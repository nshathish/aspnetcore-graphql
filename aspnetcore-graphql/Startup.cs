namespace Aspnetcore.Graphql
{
    using Data;
    using GraphQL.Server;
    using Infrastructure.Queries;
    using Infrastructure.Schemas;
    using Infrastructure.Types;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Repositories;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SqliteDbContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("SqliteConnection")));

            services.AddScoped<ProductRepository>();
            services.AddScoped<ProductReviewRepository>();

            services
                .AddScoped<ProductType>()
                .AddScoped<ProductTypeEnumType>()
                .AddScoped<ProductReviewType>()
                .AddScoped<CarvedRockQuery>()
                .AddScoped<CarvedRockSchema>()
                .AddGraphQL(options => options.EnableMetrics = true)
                .AddSystemTextJson()
                .AddErrorInfoProvider(options => options.ExposeExceptionStackTrace = true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, SqliteDbContext dbContext)
        {
            app.UseGraphQL<CarvedRockSchema>();
            app.UseGraphQLPlayground();

            dbContext.Seed();
        }
    }
}