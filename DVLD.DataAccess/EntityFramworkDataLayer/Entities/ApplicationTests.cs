using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities
{
    public class ApplicationTests
    {
        [Key]
        [Column("ApplicationTests_Id")]
        public int ApplicationTests_Id { get; set; }

        public bool isVisionTestPassed { get; set; }
        public bool isWrittenTestPassed { get; set; }
        public bool isStreetTestPassed { get; set; }

        // NOTE (Houdaifa) Add Lists
    }
}
