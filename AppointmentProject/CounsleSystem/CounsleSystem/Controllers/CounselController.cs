using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CounsleSystem.Models;


namespace CounsleSystem.Controllers
{
    public class CounselController : Controller
    {

        [HttpGet]
        [AllowAnonymous]
        // GET: Counsel
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(user user)
        {
            if (ModelState.IsValid)
            {
                ServiceManager objManager = new ServiceManager();
                user objUser = objManager.UserValid(user.username, user.password);
                bool success = objUser == null ? false : true;


                if (success == true)
                {
                    var UserID = objUser.id;
                    var LoginType = objUser.type;
                    if (string.IsNullOrEmpty(Convert.ToString(LoginType)))
                    {
                        ModelState.AddModelError("Error", "Rights to User are not Provide Contact to Admin");
                        return View(user);
                    }
                    else
                    {
                        Session["Name"] = user.username;
                        Session["UserID"] = UserID;
                        Session["LoginType"] = LoginType;

                        if (LoginType == "student")
                        {
                            return RedirectToAction("Index", "Student");
                        }
                        else if (LoginType == "admin")
                        {
                            return RedirectToAction("Index", "Admin");
                        }
                        else
                        {
                            return RedirectToAction("Index", "Counseler");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Please enter valid Username and Password");
                    return View(user);
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Please enter Username and Password");
            }
            return View(user);

        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }
}