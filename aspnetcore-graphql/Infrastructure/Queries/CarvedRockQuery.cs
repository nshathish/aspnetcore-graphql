namespace Aspnetcore.Graphql.Infrastructure.Queries
{
    using GraphQL.Types;
    using Repositories;
    using Types;

    public class CarvedRockQuery: ObjectGraphType
    {
        public CarvedRockQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>("products", resolve: _ => productRepository.GetAll());
        }
        
    }
}