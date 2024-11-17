using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.Infrastructure.Areas.Admin.Models;
using Web.Integration.AddCategoryAdmin.Command;
using Web.Integration.DeleteCategoryAdmin.Command;
using Web.Integration.GetAllCategoryAdmin.Query;
using Web.Integration.GetCategoryAdminById.Query;
using Web.Integration.UpdateCategoryAdmin.Command;

namespace Web.Infrastructure.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {
        private readonly IMediator mediator;
        public CategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var result = await mediator.Send(new GetAllCategoryAdminQuery());
            var model = new CategoryAdminModel();
            model.Categories = result.Categories;
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryAdminModel? model)
        {
            var command = new AddCategoryAdminCommand { CategoryName = model.CategoryName };
            var result = await mediator.Send(command);
            if (result.Status)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Update(string? categoryId)
        {
            var query = new GetCategoryAdminByIdQuery
            {
                CategoryId = categoryId
            };
            var response = await mediator.Send(query);
            var model = new CategoryAdminModel();
            model.CategoryId = categoryId;
            model.CategoryName = response.Category.CategoryName;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryAdminModel? model)
        {
            var command = new UpdateCategoryAdminCommand { CategoryId = model.CategoryId, CategoryName = model.CategoryName };
            var result = await mediator.Send(command);
            if (result.Status)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(string? categoryId)
        {
            var command = new DeleteCategoryAdminCommand { CategoryId = categoryId };
            var result = await mediator.Send(command);
            if (result.Status)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }

    }
