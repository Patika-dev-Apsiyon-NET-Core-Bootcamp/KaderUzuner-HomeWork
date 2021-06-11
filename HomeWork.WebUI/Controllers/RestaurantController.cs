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
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _restaurantService;
        private readonly IMapper _mapper;
        public RestaurantController(IRestaurantService restaurantService,IMapper mapper)
        {
            _mapper = mapper;
            _restaurantService = restaurantService;


        }
      
        public async Task<IActionResult> Index()
        {
            var restaurant = await _restaurantService.GetAll();
            return View(_mapper.Map<List<RestaurantDto>>(restaurant));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Create(RestaurantDto restaurantDto)
        {
            if (!ModelState.IsValid)
            {
                await _restaurantService.Add(_mapper.Map<Restaurant>(restaurantDto));
                return RedirectToAction("Index");
            }
            return View(restaurantDto);

        }

    }
}
