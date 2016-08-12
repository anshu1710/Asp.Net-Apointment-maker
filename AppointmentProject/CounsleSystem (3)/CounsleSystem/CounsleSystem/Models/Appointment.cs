using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CounsleSystem.Models
{
    public class Appointment

    {
        public int id { get; set; }

        public int studentid { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
        public Boolean isAccept { get; set; }
        public string updatedBy { get; set; }

    }
}