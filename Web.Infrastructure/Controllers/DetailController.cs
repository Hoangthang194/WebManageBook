using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Web.Infrastructure.Models.Detail;
using Web.Integration.GetAllBook.Query;
using Web.Integration.GetAllStatusBook.Query;
using Web.Integration.GetCategoryAdminById.Query;

namespace Web.Infrastructure.Controllers
{
    public class DetailController : Controller
    {
        private readonly IMediator mediator;
        public DetailController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(string? bookId)
        {
            var query = new GetAllBookQuery();

            var result = await mediator.Send(query);
            var book = result.Books.Where(x => x.BookId == bookId).FirstOrDefault();
            // get name category
            var categoryQuery = new GetCategoryAdminByIdQuery { CategoryId = book.CategoryId };
            var category = await mediator.Send(categoryQuery);
            // get status name
            var statusQuery = new GetAllStatusBookQuery();
            var status = await mediator.Send(statusQuery);
            var statusName = status.Status.Where(x=>Convert.ToInt32(x.StatusId) == book.BookStatus).FirstOrDefault()?.StatusName;
            // get review
            // model
            var model = book.Adapt<DetailBookModel>();
            model.CategoryName = category.Category.CategoryName;
            model.BookStatusName = statusName;
            model.Books = result.Books;
            return View(model);
        }
        
    }
}
