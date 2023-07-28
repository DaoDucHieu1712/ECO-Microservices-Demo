using Contracts.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECO.Service.Inventory.Enitties
{
    [Table("Iventory")]
    public class Inventory : BaseEntity<int>
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public float Discount { get; set; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }

        [ForeignKey("ColorId")]
        public Color Color { get; set; }
        [ForeignKey("SizeId")]
        public Size Size { get; set; }
    }
}
