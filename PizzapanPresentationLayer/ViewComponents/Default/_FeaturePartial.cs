using Microsoft.AspNetCore.Mvc;

namespace PizzapanPresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.title1 = "Her Gün Pizza Yiyin";
            ViewBag.title2 = "Sevdiğiniz Pizzaları Paylaşın";
            return View();
        }
    }


}
