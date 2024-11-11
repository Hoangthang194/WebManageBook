using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
