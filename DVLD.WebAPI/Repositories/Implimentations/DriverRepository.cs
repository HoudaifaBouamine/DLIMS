using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.WebAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DVLD.WebAPI.Repositories.Implimentations
{
    public class DriverRepository : IDriverRepository
    {
        private readonly AppDbContext _db;

        public DriverRepository(AppDbContext db)
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
        
        public async Task<DriverReadDto?> LoginDriverAsync(string email,string password)
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

            if(! driver.IsCorrectPassword(password))
            {
                Debug.WriteLine("---> Password is wrong");
                return null;
            }

            return driver.ToDto(person);
        }
    
        public async Task<DriverReadDto?> CreateDriverAsync(Driver driver)
        {
            if(driver.Person is null)
            {
                return null;
            }
            _db.Persons.Add(driver.Person);
            await _db.SaveChangesAsync();
            
            _db.Drivers.Add(driver);
            await _db.SaveChangesAsync();

            return driver.ToDto(driver.Person);
        }

    }
}
