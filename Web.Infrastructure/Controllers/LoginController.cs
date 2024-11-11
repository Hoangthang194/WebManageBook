using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
