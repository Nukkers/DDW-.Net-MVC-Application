using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoctorBookingSystem.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public string PatientName { get; set; }
        public string IllnessDescription { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string GpName { get; set; }
        public string Surgery { get; set; }


    }

}