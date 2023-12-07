using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples
{
    public class User
    {

        [Key]
        [Column(nameof(User_Id))]
        public int User_Id { get; set; }


        [ForeignKey(nameof(Person))]
        [Column(nameof(Person_Id))]
        public int Person_Id { get; set; }
        public Person Person { get; set; } = null!;

        [Column(TypeName = "nvarchar(15)")]
        [MinLength(1)]
        public string UserName { get; set; } = string.Empty;
        public bool isActive { get; set; } 
        public int Permission {  get; set; }

        [Column(TypeName ="nvarchar(20)")]
        [MinLength(1)]
        public string Password { get; set; } = string.Empty;
    
    }

}
