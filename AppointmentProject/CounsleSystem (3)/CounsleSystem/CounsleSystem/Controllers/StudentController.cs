using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CounsleSystem.Models;

namespace CounsleSystem.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        // POST: Student
        public Boolean  Create(string Date,string Time)
        {
            try {
                CounselRequest request = new CounselRequest();
                request.date = Convert.ToDateTime(Date);
                request.time = TimeSpan.Parse(Time);
                request.name = Session["Name"].ToString();
                request.studentid = Convert.ToInt32(Session["UserID"].ToString());
                request.updatedby = Session["Name"].ToString();
                request.isaccept = "false";
                ServiceManager objManger = new ServiceManager();
                objManger.CreateRequest(request);
               return true;
            }
            catch (Exception ex) { }
            return false;
        }
    }
}