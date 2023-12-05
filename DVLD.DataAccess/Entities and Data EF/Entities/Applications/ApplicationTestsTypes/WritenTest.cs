using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestsTypes
{
    public class WritenTest
    {
        [Key]
        [Column(nameof(WritenTest_Id))]
        public int WritenTest_Id { get; set; }


        [ForeignKey(nameof(ApplicationTests))]
        [Column(nameof(ApplicationTests_Id))]
        public int ApplicationTests_Id { get; set; }
        public ApplicationTests ApplicationTests { get; set; } = null!;


        [ForeignKey(nameof(Fees))]
        [Column(nameof(Fees_Id))]
        public int Fees_Id { get; set; }
        public ApplicationTestFees Fees { get; set; } = null!;


        public DateTime TestTime { get; set; }

        public bool IsPassed { get; set; }

        [Column(TypeName = "decimal(3,2)")]
        public float? Mark { get; set; } = null;

    }
}
