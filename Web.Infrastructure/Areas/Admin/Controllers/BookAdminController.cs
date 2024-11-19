using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.Infrastructure.Areas.Admin.Models;
using Web.Integration.AddBookAdmin.Command;
using Web.Integration.GetAllBookAdmin.Query;
using Web.Integration.GetAllCategoryAdmin.Query;
using Web.Integration.GetAllStatusBook.Query;
using Web.Integration.UpdateBookAdmin.Command;

namespace Web.Infrastructure.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookAdminController : Controller
    {
        private readonly IMediator mediator;
        public BookAdminController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var query = new GetAllBookAdminQuery();
            var res = await mediator.Send(query);
            var model = new BookAdminModel { Books = res.Books };
            return View(model);
        }

        public async Task<IActionResult> CreateBook()
        {
            // Get cate
            var res = await mediator.Send(new GetAllCategoryAdminQuery());
            // Get status
            var status = await mediator.Send(new GetAllStatusBookQuery());
            var model = new BookAdminModel();
            model.Categories = res.Categories;
            model.Status = status.Status;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBook(BookAdminModel? model)
        {
            var command = model.Adapt<AddBookAdminCommand>();
            var result = await mediator.Send(command);
            if (result.Status)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Update(string? bookId)
        {
            // Get cate
            var res = await mediator.Send(new GetAllCategoryAdminQuery());
            // Get status
            var status = await mediator.Send(new GetAllStatusBookQuery());
            var books = await mediator.Send(new GetAllBookAdminQuery());
            var book = books.Books.Where(x=>x.BookId == bookId).FirstOrDefault();
            var model = book.Adapt<BookAdminModel>();
            model.Categories = res.Categories;
            model.Status = status.Status;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Update(BookAdminModel? model)
        {
            var command = model.Adapt<UpdateBookAdminCommand>();

            command.PriceNew = command.PriceOld - (command.PriceOld * command.PercentVourcher/100);
            var result = await mediator.Send(command);
            if (result.Status) {
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
