using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Areas.Admin.Controllers
{
    public class top_nav_sidebarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
