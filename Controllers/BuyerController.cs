using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZalakProject.Data;
using ZalakProject.Manager.Buyer;
using ZalakProject.ViewModels;

namespace ZalakProject.Controllers
{
    [Authorize(Roles ="Buyer")]
    public class BuyerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBuyerService _buyerService;
        public BuyerController(ApplicationDbContext context,IBuyerService buyerService) 
        {
            _context = context;
            _buyerService = buyerService;
        }
        public async Task<IActionResult> Dashboard(int pageNumber = 1)
        {
            var products = await _buyerService.GetProductList(pageNumber);
            return View(products);
        }
        public async Task<IActionResult> ViewDetails(string productId)
        {
            var viewModel = await _buyerService.ViewMoreDetails(productId);
            return View(viewModel);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
