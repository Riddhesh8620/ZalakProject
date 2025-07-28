using Microsoft.EntityFrameworkCore;
using ZalakProject.Data;
using ZalakProject.Manager.ProductManager;
using ZalakProject.Models;
using ZalakProject.ViewModels;

namespace ZalakProject.Manager.Buyer
{
    public class BuyerService:IBuyerService
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductService _productService;

        public BuyerService(ApplicationDbContext context,IProductService productService)
        {
            _context = context;
            _productService = productService;
        }

        //public async Task<ProductListViewModel>
    }
}
