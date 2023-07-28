using Contracts.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECO.Service.Inventory.Enitties
{
    [Table("Size")]
    public class Size : BaseEntity<int>
    {
        public Size()
        {
            Inventories = new HashSet<Inventory>();
        }

        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
    }
}
