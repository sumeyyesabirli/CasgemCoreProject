using Microsoft.AspNetCore.Mvc;

namespace PizzapanPresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
