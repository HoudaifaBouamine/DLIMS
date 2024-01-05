using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.WebAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DVLD.WebAPI.Repositories.Implimentations
{
    public class DriverRepository : IDriverRepository
    {
        private readonly dbContextDVLD _db;

        public DriverRepository(dbContextDVLD db)
        {
            _db = db;
        }
        public async Task<DriverReadDto?> ReadDriverAsync(int id)
        {
             Driver? driver = await _db.Drivers.Where(d => d.Driver_Id == id).FirstOrDefaultAsync();

            if(driver is null) 
            {
                return null;
            }
            

            Person? person = await _db.Persons.Where(p => p.Person_Id == driver.Person_Id).FirstOrDefaultAsync();


            DriverReadDto driverRead = driver.ToDto(person!);

            return driverRead;
        }
        
        public async Task<DriverReadDto?> ReadDriverAsync(string email,string password)
        {
            Person? person = await _db.Persons.Where(p => p.Email == email).FirstOrDefaultAsync();

            if(person == null)
            {
                Debug.WriteLine("---> No Person With this Email");
                return null;
            }

            Driver? driver = await _db.Drivers.Where(d => d.Person_Id == person.Person_Id).FirstOrDefaultAsync();
            
            if(driver == null)
            {
                Debug.WriteLine("---> No driver For this person");
                return null;
            }


            return driver.ToDto(person);
        }
    }
}
