using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications;
using Microsoft.EntityFrameworkCore;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.License;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestsTypes;


namespace DVLD.DataAccess.EntityFramworkDataLayer.Data
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
        public DbSet<WritenTest> WritenTests { get; set;} = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Application> Applications { get; set; } = null!;

        public string ConnectionString { get;  }

        private readonly IConfiguration _configuration;
        public dbContextDVLD(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("DefaultConnection")!;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
