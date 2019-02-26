using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DoctorBookingSystem.Models
{
    public class Staff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Boolean Admin { get; set; }
        public string Surgery { get; set; }

        public List<Appointment> Appointments { get; set; }
    }
}