using Microsoft.AspNetCore.Mvc;

namespace PizzapanPresentationLayer.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
