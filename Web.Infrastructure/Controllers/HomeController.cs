using System.Diagnostics;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.Infrastructure.Models.Detail;
using Web.Integration.GetAllBook.Query;
namespace Web.Infrastructure.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMediator mediator;
        public HomeController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var query = new GetAllBookQuery();

            var result = await mediator.Send(query);

            return View(result.Books);
        }

        
    }
}
