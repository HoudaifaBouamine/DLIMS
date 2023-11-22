using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples
{
    public class Driver
    {

        [Key]
        [Column(nameof(Driver_Id))]
        public int Driver_Id { get; set; }

        [ForeignKey("Person")]
        [Column(nameof(Person_Id))]
        public int Person_Id { get; set; }
        Person? Person { get; set; } = null;

    }


}

