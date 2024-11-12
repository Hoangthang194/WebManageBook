using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
