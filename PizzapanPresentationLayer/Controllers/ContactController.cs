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

        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            _contactService.TInsert(contact);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = _contactService.TGetById(id);
            return View(value);

        }
        public IActionResult UpdateContact(Contact contact)
        {
            _contactService.TUpdate(contact);
            return RedirectToAction("Index");
        }
    }
}
