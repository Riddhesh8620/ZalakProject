using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZalakProject.Data;
using ZalakProject.Manager.Buyer;
using ZalakProject.Manager.ReviewManager;
using ZalakProject.Models;
using ZalakProject.ViewModels;

namespace ZalakProject.Controllers
{
    [Authorize(Roles ="Buyer")]
    public class BuyerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBuyerService _buyerService;
        private readonly IReviewService _reviewService;
        private readonly UserManager<ApplicationUser> _userManager;
        public BuyerController(ApplicationDbContext context, IBuyerService buyerService, IReviewService reviewService, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _buyerService = buyerService;
            _reviewService = reviewService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Dashboard(int pageNumber = 1)
        {
            var products = await _buyerService.GetProductList(pageNumber);
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult> ViewDetails(string productId)
        {
            var viewModel = await _buyerService.ViewMoreDetails(productId);
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> PostReview(ReviewViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            await _reviewService.AddReview(model, user.Id);

            return RedirectToAction("ViewDetails", new { productId = model.ProductId });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
