using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZalakProject.Data;

namespace ZalakProject.Controllers
{
    [Authorize(Roles ="Buyer")]
    public class BuyerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BuyerController(ApplicationDbContext context) 
        {
            _context = context;
        }
        public IActionResult Dashboard()
        {

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
