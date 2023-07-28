using Contracts.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECO.Service.Basket.Enities
{
    [Table("CartItem")]
    public class CartItem : BaseEntity<int>
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        public Cart? Cart { get; set; }
    }
}
