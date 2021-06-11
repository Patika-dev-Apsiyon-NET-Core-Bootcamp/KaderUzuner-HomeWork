using AutoMapper;
using HomeWork.Application.Interface;
using HomeWork.Domain.Models;
using HomeWork.WebUI.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _mapper = mapper;
            _categoryService = categoryService;


        }
       
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAll();
            return View(_mapper.Map<List<CategoryDto>>(categories));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            if (!ModelState.IsValid)
            {
                await _categoryService.Add(_mapper.Map<Category>(categoryDto));
                return RedirectToAction("Index");
            }
            return View(categoryDto);

        }

    }
}
