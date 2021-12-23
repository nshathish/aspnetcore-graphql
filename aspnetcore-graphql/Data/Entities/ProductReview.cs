namespace Aspnetcore.Graphql.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class ProductReview
    {
        public int Id { get; set; }
        [StringLength(200), Required]
        public string Title { get; set; }
        public string Review { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

    }
}