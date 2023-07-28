using Contracts.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECO.Service.Basket.Enities
{
    [Table("Cart")]
    public class Cart : BaseEntity<int>
    {
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
        }

        public string UserName { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
