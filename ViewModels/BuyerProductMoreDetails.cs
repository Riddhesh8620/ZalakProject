using ZalakProject.Models;

namespace ZalakProject.ViewModels
{
    public class BuyerProductMoreDetails  : ProductListViewModel
    {
        public List<Review> reviews { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
