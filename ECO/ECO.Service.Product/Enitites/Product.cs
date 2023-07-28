using Contracts.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECO.Service.Product.Enitites
{
    [Table("Product")]
    public class Product : BaseEntity<int>
    {
        public Product() { 
            ProductCategories = new HashSet<ProductCategory>();
        }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
