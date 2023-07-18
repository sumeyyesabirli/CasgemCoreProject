using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using PizzapanBusinessLayer.Abstract;
using PizzapanBusinessLayer.ValidationRules.OurTeamValidation;
using PizzapanEntityLayer.Concrete;

namespace PizzapanPresentationLayer.Controllers
{
    public class OurTeamController : Controller
    {
        private readonly IOurTeamService _ourTeamService;

        public OurTeamController(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddOurTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOurTeam(OurTeam ourTeam)
        {
            CreateOurTeamValidator createOurTeamValidator = new CreateOurTeamValidator();
            ValidationResult result = createOurTeamValidator.Validate(ourTeam);
            if (result.IsValid)
            {
                _ourTeamService.TInsert(ourTeam);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
