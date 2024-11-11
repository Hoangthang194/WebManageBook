using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Controllers
{
    public class AccoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
