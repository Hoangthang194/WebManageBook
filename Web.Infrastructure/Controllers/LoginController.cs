using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.Infrastructure.Models.Login;
using Web.Integration.Register.Command;

namespace Web.Infrastructure.Controllers
{
    public class LoginController : Controller
    {
        private readonly IMediator mediator;
		private readonly ISessionService sessionService;
		public LoginController(IMediator mediator, ISessionService sessionService)
        {
            this.mediator = mediator;
            this.sessionService = sessionService;
        }
        public IActionResult Index()
        {
            return View();
        }

        // Register
        [HttpPost]
        public async Task<IActionResult> Index(LoginModel? model)
        {
            // Xử lý logic
            // + Controller _> service
            var command = model.Adapt<RegisterCommand>();
            var result =await mediator.Send(command);
            if (result.Status)
            {
				this.sessionService.SetSessionData("userEmail", model.UserEmail);
				this.sessionService.SetSessionData("userId", result.UserId);
				return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
		//Login
		[HttpPost]
		public async Task<IActionResult> Login(LoginModel? model)
		{
            
		    bool isAuthenticated = await this.sessionService.AuthenticateUser(model.UserEmail, model.Password);
		    if (isAuthenticated)
		    {
		    	this.sessionService.SetSessionData("userEmail", model.UserEmail);
		    	return RedirectToAction("Index", "Home");
		    }
            return RedirectToAction("Index");
        }

		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			return RedirectToAction("Index");
		}

	}
}
