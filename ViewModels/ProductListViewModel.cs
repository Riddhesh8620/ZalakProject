using ZalakProject.Models;

namespace ZalakProject.ViewModels
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
        public string? SearchTerm { get; set; }
        public int? CategoryId { get; set; }
        public double? Price { get; set; }
        public int? MinRating { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; }
        public int PageSize { get; set; } = 12;
        public int TotalProducts { get; set; }
    }
}
