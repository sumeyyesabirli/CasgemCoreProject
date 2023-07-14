using Microsoft.AspNetCore.Mvc;
using PizzapanBusinessLayer.Abstract;
using PizzapanEntityLayer.Concrete;

namespace PizzapanPresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }

        public ActionResult GetMessageByTesekkur()
        {
            var values = _contactService.TGetContactBySubjectWithTesekkur();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return RedirectToAction("Index");
        }

    }
}
