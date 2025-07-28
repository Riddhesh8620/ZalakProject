using System.ComponentModel.DataAnnotations;

namespace ZalakProject.Models
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        [StringLength(500)]
        public string ImagePath { get; set; } = string.Empty;

        [StringLength(200)]
        public string? Alt { get; set; }

        public bool IsPrimary { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation properties
        public virtual Product Product { get; set; } = null!;
    }
}
