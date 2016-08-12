using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CounsleSystem.Models;

namespace CounsleSystem.Controllers
{
    public class CounselerController : Controller
    {
        // GET: Counseler
        public ActionResult Index()
        {
            ServiceManager objManager = new ServiceManager();
            IEnumerable<CounselRequest> lstRequest = objManager.GetRequests();
            return View(lstRequest);
        }
        public ActionResult Edit(int id)
        {
            ServiceManager objManager = new ServiceManager();
            IEnumerable<CounselRequest> lstRequest = objManager.GetRequests();
            CounselRequest request = lstRequest.Where(m => m.id == id).FirstOrDefault();
            return View(request);
        }

        [HttpPost]
        public ActionResult Edit(CounselRequest request)
        {
            ServiceManager objManager = new ServiceManager();
            
             objManager.UpdateRequest(request);

            return RedirectToAction("Index");
        }

        public ActionResult Modify(int id)
        {
            ServiceManager objManager = new ServiceManager();
            ObjectManager CManager = new ObjectManager();
            IEnumerable<CounselRequest> lstRequest = objManager.GetRequests();
            CounselRequest request = lstRequest.Where(m => m.id == id).FirstOrDefault();
            
            return View(CManager.ConvertCounselRequesttoAppointment(request));
        }

        [HttpPost]
        public ActionResult Modify(Appointment request)
        {
            ServiceManager objManager = new ServiceManager();
            ObjectManager CManager = new ObjectManager();
            CounselRequest objrequest = CManager.ConvertAppointmentttoCounselRequest(request);
                objrequest.updatedby = Session["Name"].ToString();
            objManager.UpdateRequest(objrequest);

            return RedirectToAction("Index");
        }
    }
}