using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
