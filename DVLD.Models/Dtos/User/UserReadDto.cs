using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models.Dtos.User
{
    public class UserReadDto
    {
        public int User_Id { get; set; }
        public int Person_Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public bool isActive { get; set; }
        public int Permission { get; set; }
        public string Password { get; set; } = string.Empty;

        //
        public int Nationality_Id { get; set; }
        public string NationalNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string? SecondName { get; set; } = null;
        public string? ThirddName { get; set; } = null;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string AddressLine { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string? PersonalPictureURL { get; set; } = null;

    }
}
