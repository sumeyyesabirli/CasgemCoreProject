using Microsoft.AspNetCore.Mvc;

namespace PizzapanPresentationLayer.ViewComponents.Default
{
    public class _DescriptionPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
