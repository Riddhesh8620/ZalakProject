using ZalakProject.Models;
using ZalakProject.ViewModels;

namespace ZalakProject.Manager.ProductManager
{
    public interface IProductService
    {
        Task<List<ProductListViewModel>> GetAllProductsBySellerId(string sellerId);
    }
}
