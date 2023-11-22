using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications
{
    public class ApplicationTestFees
    {
        [Key]
        [Column("ApplicationsTestFees_Id")]
        public int ApplicationsTestFees_Id { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Fees { get; set; }

        // NOTE (Houdaifa) : Add lists

    }
}
