using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CounsleSystem.Models
{
    public class ObjectManager
    {
        public Appointment ConvertCounselRequesttoAppointment(CounselRequest request)
        {
            return new Appointment()
            {
                date = request.date,
                time = request.time,
                id = request.id,
                isAccept = Convert.ToBoolean(request.isaccept),
                name = request.name,
                studentid = request.studentid,
                updatedBy = request.updatedby
            };
        }
        public CounselRequest ConvertAppointmentttoCounselRequest(Appointment appointment)
        {
            return new CounselRequest()
            {
                date = appointment.date,
                time = appointment.time,
                id = appointment.id,
                isaccept = appointment.isAccept.ToString(),
                name = appointment.name,
                studentid = appointment.studentid,
                updatedby = appointment.updatedBy
            };
        }

        public List<Appointment> ConvertlstCounselRequesttolstAppointments(IEnumerable<CounselRequest> requests)
        {
            List<Appointment> lstAppointment = new List<Appointment>();
            foreach (CounselRequest item in requests)
                lstAppointment.Add(ConvertCounselRequesttoAppointment(item));

            return lstAppointment;

        }
    }
}