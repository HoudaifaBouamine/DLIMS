using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples
{
    public class Person
    {
        [Key]
        [Column(nameof(Person_Id))]
        public int Person_Id { get; set; }

        [ForeignKey("Nationality")]
        [Column(nameof(Nationality_Id))]
        public int Nationality_Id { get; set; }
        public Nationality? Nationality { get; set; } = null;

        [MaxLength(50)]
        public string NationalNumber { get; set; } =string.Empty;

        
        
        [MaxLength(30)]
        [MinLength(1)]

        public string FirstName { get; set; } = string.Empty;

        [MaxLength(30)]
        [MinLength(1)]
        public string? SecondName { get; set; } = null;

        [MaxLength(30)]
        [MinLength(1)]
        public string? ThirddName { get; set; } = null;
        
        [MaxLength(30)]
        [MinLength(1)]
        public string LastName { get; set; } =string.Empty;


        [MaxLength(30)]
        [MinLength(1)]
        public string Email {get; set; } =string.Empty;


        [MaxLength(20)]
        [MinLength(1)]
        public string Phone { get; set; } = string.Empty;


        [MaxLength(100)]
        [MinLength(1)]
        public string AddressLine { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }

        [MaxLength(100)]
        public string? PersonalPictureURL;

    }
}
