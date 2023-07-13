﻿using Microsoft.AspNetCore.Mvc;
using PizzapanBusinessLayer.Abstract;
using PizzapanEntityLayer.Concrete;

namespace PizzapanPresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category) 
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id) 
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return RedirectToAction("Index");
        }
        
    }
}
