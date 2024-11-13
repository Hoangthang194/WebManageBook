using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class collapsed_sidebarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
