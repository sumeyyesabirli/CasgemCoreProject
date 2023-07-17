using Microsoft.AspNetCore.Mvc;

namespace PizzapanPresentationLayer.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
       
    }
}
