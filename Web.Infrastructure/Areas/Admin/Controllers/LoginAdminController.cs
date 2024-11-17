using Microsoft.AspNetCore.Mvc;
using Web.Infrastructure.Areas.Admin.Models;

namespace Web.Infrastructure.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class LoginAdminController : Controller
    {
        private readonly ISessionService sessionService;
        public LoginAdminController(ISessionService sessionService)
        {
            this.sessionService = sessionService;
        }

        public IActionResult Index()
        {
            var userEmail = Request.Cookies["userEmailAdmin"];
            var password = Request.Cookies["passwordAdmin"];
            if (!string.IsNullOrEmpty(userEmail) && !string.IsNullOrEmpty(password))
            {
                var model = new LoginAdminModel { UserEmail = userEmail, UserPassword = password };
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginAdminModel? model)
        {
            if (ModelState.IsValid)
            {
                bool isAuthenticated = await sessionService.AuthenticateUser(model.UserEmail, model.UserPassword);
                if (isAuthenticated)
                {
                    sessionService.SetSessionData("userEmailAdmin", model.UserEmail);
                    if (model.SavePass)
                    {
                        HttpContext.Response.Cookies.Append("userEmailAdmin", model.UserEmail, new CookieOptions
                        {
                            Expires = DateTimeOffset.UtcNow.AddDays(30)
                        });
                        HttpContext.Response.Cookies.Append("passwordAdmin", model.UserPassword, new CookieOptions
                        {
                            Expires = DateTimeOffset.UtcNow.AddDays(30)
                        });
                    }
                    return RedirectToAction("Index", "BookAdmin", new { area = "Admin" });
                }
            }
            return View(model);
        }
    }
}
