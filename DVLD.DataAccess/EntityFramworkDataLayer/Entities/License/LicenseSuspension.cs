using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.License
{
    public class LicenseSuspension
    {

        [Key]
        [Column(nameof(LicenseSuspension_Id))]
        public int LicenseSuspension_Id { get; set; }

        [ForeignKey("License")]
        [Column(nameof(License_Id))]
        public int License_Id { get; set; }
        public License License { get; set; } = null!;

        [Column(TypeName ="decimal(18,2)")]
        public decimal Fees { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [MinLength(1)]
        public string SuspensionReason { get; set; } = string.Empty;

        public DateTime SuspenstionDate { get; set; }

        public DateTime? SuspenstionCancelDate { get; set; } = null;

    }
}
