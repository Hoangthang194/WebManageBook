﻿using Microsoft.AspNetCore.Mvc;

namespace Web.Infrastructure.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
