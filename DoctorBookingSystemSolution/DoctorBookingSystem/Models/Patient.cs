using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoctorBookingSystem.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string IllnessDescription { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string GpName { get; set; }
        public string Surgery { get; set; }
    }

    public class PatientDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
    }
}