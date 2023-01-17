using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopMVC.Models
{
    public class ProductsViewModel
    {
        [DisplayName("Product ID")]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DisplayName("Product Description")]
        public string Description { get; set; }
        [DisplayName("Product Price")]
        public double Price { get; set; }
        [DisplayName("Product Category")]
        [MaxLength(20)]
        public string? Category { get; set; }

    }
}
