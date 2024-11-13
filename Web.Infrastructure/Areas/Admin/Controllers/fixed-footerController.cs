using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class fixed_footerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
