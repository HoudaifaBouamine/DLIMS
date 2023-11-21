using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities
{
    public class Nationality
    {

        [Key]
        [Column("Nationality_Id")]
        public int Nationality_Id { get; set; }

        [MaxLength(50)]
        public string NationalityName { get; set; } = string.Empty;

        [MaxLength(50)]
        public string CountryName { get; set; } = string.Empty;


        // NOTE (Houdaifa) : Add lists

    }
}
