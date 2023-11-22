using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications
{
    public class ApplicationStatus
    {
        [Key]
        [Column("ApplicationStatus_Id")]
        public int ApplicationStatus_Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;
    }
}
