using Microsoft.EntityFrameworkCore;
using SebaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Doctor & DoctorInformation entity
            modelBuilder.Entity<Doctor>().HasOne(a => a.DoctorInformation).WithOne(ad => ad.Doctor).HasForeignKey<DoctorInformation>(d => d.doctorID);
            modelBuilder.Entity<DoctorImage>().HasOne<Doctor>(s => s.Doctor).WithMany(i => i.DoctorImages).HasForeignKey(f => f.doctorID);
           
            modelBuilder.Entity<Patient>().HasOne(a => a.PatientInformation).WithOne(ad => ad.Patient).HasForeignKey<PatientInformation>(d => d.PatienID);
            modelBuilder.Entity<Patient>().HasOne(a => a.AccountBalance).WithOne(ad => ad.Patient).HasForeignKey<AccountBalance>(d => d.PatienID);



            modelBuilder.Entity<Appointment>().HasKey(ap => new
            {       
                ap.doctorID,
                ap.PatienID
            });
            modelBuilder.Entity<Appointment>().HasOne(d => d.Doctor).WithMany(ap => ap.Appointments).HasForeignKey(d =>d.doctorID);
            modelBuilder.Entity<Appointment>().HasOne(p => p.Patient).WithMany(ap => ap.Appointments).HasForeignKey(p =>p.PatienID);
            
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorInformation> DoctorInformation { get; set; }
        public DbSet<VisitingPrice> visitingPrices { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<DoctorImage> DoctorImages { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientInformation> PatientInformation { get; set; }
        public DbSet<AccountBalance> AccountBalances { get; set; }
        public DbSet<Appointment> Appointments { get; set; }


    }
}
