using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ZalakProject.Controllers
{
    [Authorize(Roles ="Buyer")]
    public class BuyerController : Controller
    {
        
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
