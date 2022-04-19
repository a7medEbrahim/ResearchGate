using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication39.Models;
namespace WebApplication39.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public ActionResult Index(int id=0)
        {
            User userModel = new User(); 
            return View(userModel);
        }
        [HttpPost]
        public ActionResult Index(WebApplication39.Models.User userModel)
        {
            using (Research_GateEntities1 dbModel = new Research_GateEntities1())
            {
                dbModel.Users.Add(userModel);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful.";
            return View("Index", new User());

        }
    }
}