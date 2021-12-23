namespace Aspnetcore.Graphql.Infrastructure.Mutations
{
    using Data.Entities;
    using GraphQL;
    using GraphQL.Types;
    using Repositories;
    using Types;

    public class CarvedRockMutation : ObjectGraphType
    {
        public CarvedRockMutation(ProductReviewRepository productReviewRepository)
        {
            FieldAsync<ProductReviewType>("createReview",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ProductReviewInputType>> {Name = "review"}
                ),
                resolve: async context =>
                {
                    var review = context.GetArgument<ProductReview>("review");
                    return await productReviewRepository.AddReview(review);
                }
            );
        }
    }
}