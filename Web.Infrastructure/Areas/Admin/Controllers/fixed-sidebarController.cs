using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Areas.Admin.Controllers
{
    public class fixed_sidebarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
