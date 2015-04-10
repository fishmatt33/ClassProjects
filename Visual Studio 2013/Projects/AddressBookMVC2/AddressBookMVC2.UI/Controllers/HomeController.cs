using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AddressBookMVC2.UI.Models;

namespace AddressBookMVC2.UI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var database = new FakeDatabase();

            var contacts = database.GetAll();

            return View(contacts);
        }

        public ActionResult Add()
        {
            var model = new Contact();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddContact(Contact c)
        {
            var database = new FakeDatabase();

            database.Add(c);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var database = new FakeDatabase();
            var contact = database.GetById(id);

            return View(contact);
        }

        [HttpPost]
        public ActionResult EditContact(Contact c)
        {
            var database = new FakeDatabase();

            database.Edit(c);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteContact()
        {
            int contactId = int.Parse(Request.Form["ContactId"]);

            var database = new FakeDatabase();
            database.Delete(contactId);

            var contacts = database.GetAll();
            return View("Index", contacts);
        }
	}
}