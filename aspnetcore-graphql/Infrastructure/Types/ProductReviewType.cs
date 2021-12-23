namespace Aspnetcore.Graphql.Infrastructure.Types
{
    using Data.Entities;
    using GraphQL.Types;

    public sealed class ProductReviewType: ObjectGraphType<ProductReview>
    {
        public ProductReviewType()
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Review);
        }
        
    }
}