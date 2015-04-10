using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using AddressBookMVC.UI.Models;

namespace AddressBookMVC.UI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var database = new FakeContactDatabase();

            // ask the database to get all the contacts
            var contacts = database.GetAll();

            // inject the contact data into the view
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
            //// create a contact
            //var c = new Contact();

            //// get the data from the input fields Name and PhoneNumber
            //c.Name = Request.Form["Name"];
            //c.PhoneNumber = Request.Form["PhoneNumber"];

            // create our fake database
            var database = new FakeContactDatabase();
            database.Add(c);

            // add the contact record to the database
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            //// Load the id from the RouteData.
            //// It is stored as object, so we must cast it.
            //int contactId = int.Parse(RouteData.Values["id"].ToString());

            var database = new FakeContactDatabase();
            var contact = database.GetById(id);

            // inject the contact object into the view
            return View(contact);
        }

        [HttpPost]
        public ActionResult EditContact(Contact c)
        {
            //// create a contact
            //var c = new Contact();

            //// get the data from the input fields
            //// ContactId, Name, and PhoneNuumber

            //c.Name = Request.Form["Name"];
            //c.PhoneNumber = Request.Form["PhoneNumber"];
            //c.ContactId = int.Parse(Request.Form["ContactId"]);

            // create our fake dataase
            var database = new FakeContactDatabase();

            //send the edited contact redord to the database
            database.Edit(c);

            // tell the browser to navigate to Home/Index
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteContact()
        {
            int contactId = int.Parse(Request.Form["ContactId"]);

            var database = new FakeContactDatabase();
            database.Delete(contactId);

            var contacts = database.GetAll();
            return View("Index", contacts);
        }
    }
}