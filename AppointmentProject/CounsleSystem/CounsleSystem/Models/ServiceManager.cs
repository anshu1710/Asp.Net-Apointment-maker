using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CounsleSystem.Models;

namespace CounsleSystem.Models
{
    public class ServiceManager
    {
        public user UserValid(string userName, string password)
        {
            try {
                CounselEntities dbentity = new CounselEntities();
                List<user> lstUsers = dbentity.users.ToList();
                user objUser =  lstUsers.Where (m => (m.username == userName && m.password == password)).FirstOrDefault();
                return objUser;

            }
            catch (Exception ex) {
                return null;
            }
        }
        public Boolean CreateRequest(CounselRequest request)
        {
            try
            {
                CounselEntities dbentity = new CounselEntities();
                dbentity.CounselRequests.Add(request);
                dbentity.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false ;
            }
        }
        public Boolean UpdateRequest(CounselRequest request)
        {
            try
            {
                CounselEntities dbentity = new CounselEntities();
                CounselRequest objrequest = dbentity.CounselRequests.FirstOrDefault(c => c.id == request.id);
                objrequest.date  = request.date;
                objrequest.isaccept = request.isaccept;
                objrequest.name = request.name ;
                objrequest.studentid = request.studentid;
                objrequest.time  = request.time;
                objrequest.updatedby  = request.updatedby ;

                
                dbentity.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IEnumerable<CounselRequest> GetRequests()
        {
            try
            {
                CounselEntities dbentity = new CounselEntities();                
                return dbentity.CounselRequests;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}