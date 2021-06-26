using HomeWork.Application.Interface;
using HomeWork.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.WebUI.Controllers
{
    public class HomeController : Controller
    {
        ICategoryService _categoryService;
        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IActionResult>Index()
        {
            var categories = await _categoryService.GetAll();
            return View(categories);
        }
    }
}
