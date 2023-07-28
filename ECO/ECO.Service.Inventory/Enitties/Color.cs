using Contracts.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECO.Service.Inventory.Enitties
{
    [Table("Color")]
    public class Color : BaseEntity<int>
    {

        public Color() {
            Inventories = new HashSet<Inventory>();
        }

        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Inventory> Inventories { get; set;}
    }
}
