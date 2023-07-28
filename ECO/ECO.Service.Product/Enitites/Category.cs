using Contracts.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECO.Service.Product.Enitites
{
    [Table("Category")]
    public class Category : BaseEntity<int>
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
