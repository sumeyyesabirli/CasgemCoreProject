using Microsoft.AspNetCore.Mvc;

namespace PizzapanPresentationLayer.ViewComponents.Default
{
    public class _ScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
