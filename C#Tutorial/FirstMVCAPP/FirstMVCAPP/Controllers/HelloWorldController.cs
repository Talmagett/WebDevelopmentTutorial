﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstMVCAPP.Models;

namespace FirstMVCAPP.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> _dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(_dogs);
        }
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }
        public IActionResult CreateDog(DogViewModel dogViewModel) 
        {
            _dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
