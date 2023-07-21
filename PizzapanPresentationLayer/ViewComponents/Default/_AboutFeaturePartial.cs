using Microsoft.AspNetCore.Mvc;

namespace PizzapanPresentationLayer.ViewComponents.Default
{
    public class _AboutFeaturePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
