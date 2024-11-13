using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Areas.Admin.Controllers
{
    public class top_navController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
