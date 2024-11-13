using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class boxedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
