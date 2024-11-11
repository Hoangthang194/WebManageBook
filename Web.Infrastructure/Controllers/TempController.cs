using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Controllers
{
    public class TempController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
