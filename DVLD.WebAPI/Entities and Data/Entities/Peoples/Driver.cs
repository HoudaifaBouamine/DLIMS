using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples
{
    public partial class Driver
    {

        [Key]
        [Column(nameof(Driver_Id))]
        public int Driver_Id { get; set; }

        [ForeignKey("Person")]
        [Column(nameof(Person_Id))]
        public int Person_Id { get; set; }
        public Person? Person { get; set; } = null;

        public string HashedPassword { get; set; } = string.Empty;
    }

    public partial class Driver
    {
        public DriverReadDto ToDto(Person person)
        {
            this.Person = person;

            return new DriverReadDto()
            {
                Driver_Id = this.Driver_Id,
                Person = this.Person.ToDto()
            };
        }
    }

    public class DriverReadDto
    {
        public int Driver_Id { get; set; }
        public PersonReadDto? Person { get; set; } = null;

    }
    
    public class DriverLoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
