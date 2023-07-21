using Microsoft.AspNetCore.Mvc;
using PizzapanDataAccessLayer.Concrete;

namespace PizzapanPresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
      
    }
}
