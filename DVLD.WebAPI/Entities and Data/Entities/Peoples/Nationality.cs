using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples
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

    public class NationalityService 
    {
        // Because the nationalities are constant , it is waste to do join to get it every time instead let it in the main memory

        private static AppDbContext? _dbContextDVLD = null;
        public NationalityService(AppDbContext dbContextDVLD)
        {
            _dbContextDVLD ??= dbContextDVLD;
        }
        private static Dictionary<int, Nationality>? Nationalities { get; set; } = null;

        public static Nationality? GetNationalityById(int nationality_Id)
        {
            if(_dbContextDVLD == null)
            {
                return null;
            }

            if(Nationalities == null)
            {
                Nationalities = new Dictionary<int, Nationality>();

                var nalist = _dbContextDVLD!.Nationalities.ToList();

                foreach (var na in nalist)
                {
                    Nationalities.Add(na.Nationality_Id, na);
                }
            }

            return Nationalities[nationality_Id];
        }

       
       
    }

}
