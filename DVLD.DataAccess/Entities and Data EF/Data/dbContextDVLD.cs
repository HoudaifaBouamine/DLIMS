using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.License;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestsTypes;


namespace DVLD.DataAccess.EntityFramworkDataLayer
    .Data
{
    public class dbContextDVLD : DbContext
    {
        public DbSet<ApplicationStatus> ApplicationStatuses { get; set; } = null!;
        public DbSet<ApplicationTestFees> ApplicationsTestFees { get; set; } = null!;
        public DbSet<ApplicationTests> ApplicationsTests { get; set; } = null!;
        public DbSet<License> Licenses { get; set; } = null!;
        public DbSet<LicenseClass> LicenseClasses { get; set; } = null!;
        public DbSet<Driver> Drivers { get; set; } = null!;
        public DbSet<Nationality> Nationalities { get; set; } = null!;
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<LicenseSuspension> LicenseSuspensions { get; set; } = null!;
        public DbSet<PracticalTest> PracticalTests { get; set; } = null!;
        public DbSet<VisionTest> VisionTests { get; set; } = null!;
        public DbSet<WritenTest> WritenTests { get; set; } = null!;


        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Application> Applications { get; set; } = null!;

        private readonly string ConnectionString = "Data Source=.;Initial Catalog=DVLD_db;User Id=DESKTOP-OCJUBFL\\houda;Password=sa123456;Encrypt=false;Trusted_Connection=Yes;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
