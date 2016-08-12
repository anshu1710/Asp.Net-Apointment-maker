using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CounsleSystem.Models;

namespace CounsleSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            ServiceManager objManager = new ServiceManager();
            IEnumerable<CounselRequest> lstRequest = objManager.GetRequests();
            return View(lstRequest);
        }
    }
}