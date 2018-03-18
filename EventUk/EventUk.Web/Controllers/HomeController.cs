using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventUk.Web.Models.ViewModels;
using EventUk.Web.MyWork;

namespace EventUk.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactUs(ContactUsViewModel contact)
        {
            ContactUsDetails obj = new ContactUsDetails();
            string response = obj.EmailFunctionality(contact);
            if (response == "Success")
            {

            }

            return RedirectToAction("Index");
        }
    }
}