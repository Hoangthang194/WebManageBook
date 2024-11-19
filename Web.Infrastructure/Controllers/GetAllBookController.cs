using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.Infrastructure.Areas.Admin.Models;
using Web.Integration.GetAllBook.Query;
using Web.Integration.GetAllBookAdmin.Query;

namespace Web.Infrastructure.Controllers
{
    public class GetAllBookController : Controller
    {
        private readonly IMediator mediator;
        public GetAllBookController(IMediator mediator)
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
