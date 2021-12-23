namespace Aspnetcore.Graphql.Infrastructure.Types
{
    using Data.Entities;
    using GraphQL.Types;
    using Repositories;

    public sealed class ProductType : ObjectGraphType<Product>
    {
        public ProductType(ProductReviewRepository productReviewRepository)
        {
            Field(x => x.Id);
            Field(t => t.Name).Description("The name of the product");
            Field(t => t.Description);
            Field(t => t.IntroducedAt).Description("When the product was first introduced in the catalog");
            Field(t => t.PhotoFileName).Description("The file name of the photo so the client can render it");
            Field(t => t.Price);
            Field(t => t.Rating).Description("The (max 5) star customer rating");
            Field(t => t.Stock);
            Field<ProductTypeEnumType>("Type", "The type of product");
            Field<ListGraphType<ProductReviewType>>("reviews",
                resolve: context => productReviewRepository.GetForProduct(context.Source.Id));
        }
    }
}