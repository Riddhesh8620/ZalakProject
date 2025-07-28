using System.ComponentModel.DataAnnotations;

namespace ZalakProject.ViewModels
{
    public class ProductCreateViewModel
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(0.01, 999999.99)]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [Range(0, 999999)]
        public int StockQuantity { get; set; }

        public List<IFormFile>? Images { get; set; }
    }
}
