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
    public class FoodController : Controller
    {
        
            private readonly IFoodService _foodService;
            private readonly IMapper _mapper;
            public FoodController(IFoodService foodService, IMapper mapper)
            {
                _mapper = mapper;
                _foodService = foodService;


            }

            public async Task<IActionResult> Index()
            {
                var foods = await _foodService.GetAll();
                return View(_mapper.Map<List<FoodDto>>(foods));
            }
            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Create(FoodDto foodDto)
            {
                if (!ModelState.IsValid)
                {
                    await _foodService.Add(_mapper.Map<Food>(foodDto));
                    return RedirectToAction("Index");
                }
                return View(foodDto);

            }

    }
 }

