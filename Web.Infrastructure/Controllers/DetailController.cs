using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
