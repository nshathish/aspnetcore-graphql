namespace Aspnetcore.Graphql.Infrastructure.Types
{
    using Data.Entities;
    using GraphQL.Types;

    public class ProductTypeEnumType: EnumerationGraphType<ProductTypeEnum>
    {
        public ProductTypeEnumType()
        {
            Name = "Type";
            Description = "The type of the product";
        }
        
    }
}