using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTests
{
    public class PracticalTests
    {
        [Key]
        [Column(nameof(PracticalTest_Id))]
        public int PracticalTest_Id { get; set; }

        [ForeignKey(nameof(ApplicationTests))]
        [Column(nameof(ApplicationTests_Id))]
        public int ApplicationTests_Id { get; set; }
        public ApplicationTests ApplicationTests { get; set; } = null!;


        [ForeignKey(nameof(Fees))]
        [Column(nameof(Fees_Id))]
        public int Fees_Id { get; set; }
        public ApplicationTestFees Fees { get; set; } = null!;


        public DateTime AppointmentTime { get; set; }
        public DateTime? RealTestTime { get; set; } = null;

        public bool IsPassed { get; set; }

    }
}
