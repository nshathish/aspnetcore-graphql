namespace Aspnetcore.Graphql.Infrastructure.Queries
{
    using GraphQL;
    using GraphQL.Types;
    using Repositories;
    using Types;

    public class CarvedRockQuery : ObjectGraphType
    {
        public CarvedRockQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>("products", resolve: _ => productRepository.GetAll());

            Field<ProductType>("product",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> {Name = "id"}),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return productRepository.GetOne(id);
                }
            );
        }
    }
}