using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples
{
    public partial class User
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
    
    public partial class User
    {
        public UserReadDto ToDto(Person person)
        {
            this.Person = person;

            return new UserReadDto()
            {
                User_Id    = this.User_Id,
                UserName   = this.UserName,
                Permission = this.Permission,
                Person     = this.Person.ToDto()
            };
        }   
    }

    public class UserReadDto
    {

        public int User_Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int Permission { get; set; }
        public PersonReadDto Person { get; set; } = null!;
        

        /*
            {
              "user_Id": 1,
              "person": {
                "person_Id": 1,
                "nationality": null,
                "nationalNumber": "US123456",
                "firstName": "John",
                "secondName": "Michael",
                "thirddName": null,
                "lastName": "Doe",
                "email": "john.doe@example.com",
                "phone": "123-456-7890",
                "addressLine": "123 Main St, City, Country",
                "birthDate": "1980-01-15T00:00:00"
              },
              "userName": "JohnDoe123",
              "permission": 1,
            }
        */
    }

    public class UserLoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

}
