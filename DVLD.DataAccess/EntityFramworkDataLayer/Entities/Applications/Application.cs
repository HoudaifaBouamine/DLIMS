using DVLD.DataAccess.EntityFramworkDataLayer.Entities.License;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications
{
    public class Application
    {

        [Key]
        [Column(nameof(Application_Id))]
        public int Application_Id { get; set; }


        [ForeignKey(nameof(Service))]
        [Column(nameof(Service_Id))]
        public int Service_Id { get; set; }
        public Service Service { get; set; } = null!;


        [ForeignKey(nameof(Person))]
        [Column(nameof(Person_Id))]
        public int Person_Id { get; set; }
        public Person Person { get; set; } = null!;



        [ForeignKey(nameof(ApplicationStatus))]
        [Column(nameof(ApplicationStatus_Id))]
        public int ApplicationStatus_Id { get; set; }
        public ApplicationStatus ApplicationStatus { get; set; } = null!;


        [ForeignKey(nameof(Creator))]
        [Column(nameof(Creator_Id))]
        public int Creator_Id { get; set; }
        public User Creator { get; set; } = null!;




        [ForeignKey(nameof(LicenseClass))]
        [Column(nameof(LicenseClass_Id))]
        public int LicenseClass_Id { get; set; }
        public LicenseClass LicenseClass { get; set; } = null!;



        [ForeignKey(nameof(ApplicationTests))]
        [Column(nameof(ApplicationTests_Id))]
        public int ApplicationTests_Id { get; set; }
        public ApplicationTests ApplicationTests { get; set; } = null!;


        public DateTime Date { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal PayedFees { get; set; }
    }
}
