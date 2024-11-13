using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Areas.Admin.Controllers
{
    public class fixed_sidebar_customController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
