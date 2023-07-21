using Microsoft.AspNetCore.Mvc;
using PizzapanBusinessLayer.Abstract;

namespace PizzapanPresentationLayer.Controllers
{
    public class AboutPageController : Controller
    {
        private readonly IOurTeamService _ourTeamService;

        public AboutPageController(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }

        public IActionResult Index()
        {
            var values = _ourTeamService.TGetList();
            return View(values);
        }
    }
}
