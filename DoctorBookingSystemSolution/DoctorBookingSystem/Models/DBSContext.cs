using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoctorBookingSystem.Models
{
    public class DBSContext : DbContext
    { 
        public DbSet<Staff> StaffMembers { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DBSContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}