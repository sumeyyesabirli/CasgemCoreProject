using Microsoft.AspNetCore.Mvc;
using PizzapanBusinessLayer.Abstract;
using PizzapanEntityLayer.Concrete;
using PizzapanPresentationLayer.Models;
using System;
using System.IO;

namespace PizzapanPresentationLayer.Controllers
{
    public class ProductImageController : Controller
    {
        private readonly IProductImageService _productImageService;
        public ProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ImageFileViewModel model)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(model.Image.FileName);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = resource + "/wwwroot/images/" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            model.Image.CopyTo(stream);
            ProductImage productImage = new ProductImage();
            productImage.ImageUrl = imageName;
            _productImageService.TInsert(productImage);
            return RedirectToAction("ImageList");
        }
    }
}
