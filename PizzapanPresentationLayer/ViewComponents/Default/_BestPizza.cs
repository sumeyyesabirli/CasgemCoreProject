﻿using Microsoft.AspNetCore.Mvc;

namespace PizzapanPresentationLayer.ViewComponents.Default
{
    public class _BestPizza : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
