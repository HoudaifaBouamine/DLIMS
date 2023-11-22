using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.License
{
    public enum enCreationStatus { FirstCreation = 0,ReplaceForLose = 1 };
    public class License
    {
        [Key]
        [Column("License_Id")]
        public int License_Id { get; set; }


        [ForeignKey("Driver")]
        [Column(nameof(Driver_Id))]
        required public int Driver_Id {  get; set; }
        public Driver? Driver { get; set; }

        [ForeignKey("LicenseClass")]
        [Column(nameof(LicenseClass_Id))]
        required public int LicenseClass_Id { get; set; }
        public LicenseClass? LicenseClass { get; set; } = null;
        required public DateTime CreatingDate { get; set; }
        required public DateTime ExpireDate { get; set;}
        required public bool IsValied { get; set; }
        required public enCreationStatus CreationStatus {  get; set; }
        
    }
}
