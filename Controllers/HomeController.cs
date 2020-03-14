using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assessment2___Final.Models;

namespace Assessment2___Final.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // Link to Start a cause page
        public ActionResult StartAPetition()
        {
            return View();
        }

        // Link to Featured Causes page
        public ActionResult FeaturedCauses()
        {
            return View();
        }

        // Link to Categories page
        public ActionResult Categories()
        {
            return View();
        }

        /*
        // Link to Sign Up Page
        public IActionResult SignUp()
        {

            ViewBag.Message = "User Sign Up";

            return View();
        }

        /* If Sign up form data is valid, send data through post and display Homepage.
         * If not, return the user to the Sign Up page 
        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}