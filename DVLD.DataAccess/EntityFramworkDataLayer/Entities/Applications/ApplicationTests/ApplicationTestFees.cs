using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTests
{
    public class ApplicationTestFees
    {
        [Key]
        [Column(nameof(ApplicationTestFees_Id))]
        public int ApplicationTestFees_Id { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Fees { get; set; }
    }
}
