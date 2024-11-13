using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.Integration.AddToCart;

namespace Web.Infrastructure.Controllers
{
    public class CartController : Controller
    {
        private readonly ISessionService sessionService;
        private readonly IMediator mediator;
        public CartController(ISessionService sessionService, IMediator mediator)
        {
            this.sessionService = sessionService;
            this.mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
    [HttpPost]
    public async Task<IActionResult> AddToCart([FromBody] AddToCartDetailCommand request)
    {

    }
}
