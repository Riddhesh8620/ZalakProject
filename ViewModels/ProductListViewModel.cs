using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZalakProject.Models;

namespace ZalakProject.ViewModels
{
    public class ProductListViewModel
    {
        public string ProductId { get; set; }

        [Required]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string CategoryName { get; set; }

        [Required]
        public int StockQuantity{get; set; }
        public int CategoryId { get; set; }
        [Required]
        public string ProductImage {  get; set; }
        public string SellerId { get; set; }
}
