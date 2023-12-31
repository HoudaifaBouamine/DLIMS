﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.License
{
    public class LicenseClass
    {

        [Key]
        [Column("LicenseClass_Id")]
        public int LicenseClass_Id { get; set; }

        [Required] public string Name { get; set; } = string.Empty;
        [Required] public string Description { get; set; } = string.Empty;
        [Required] public int MinimumAllowedAge { get; set; }
        [Required] public TimeSpan ValiditySpan { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Fees { get; set; }

        // NOTE (Houdaifa) : Add Lists of Licenses and Applications
    }
}
