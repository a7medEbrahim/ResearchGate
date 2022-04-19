using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication39.Models;

namespace WebApplication39.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Autherize(WebApplication39.Models.User userModel)
        {
            using (Research_GateEntities1 db = new Research_GateEntities1())
            {
                var userDetails = db.Users.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();

                if (userDetails == null)
                {
                    userModel.LoginErorrMessage = "Wrong user name or password";
                    return View("Index", userModel);
                }
                else
                {
                    Session["UserName"] = userDetails.UserName;
                   return RedirectToAction("Home", "home");
                }
            }
     
        }
    
            
        
    }
    
}