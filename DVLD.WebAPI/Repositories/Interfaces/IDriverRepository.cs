using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;

namespace DVLD.WebAPI.Repositories.Interfaces
{
    public interface IDriverRepository
    {
        Task<DriverReadDto?> ReadDriverAsync(int id);
        Task<List<DriverReadDto>> ReadDriversAsync();
        Task<DriverReadDto?> LoginDriverAsync(string email,string password);
        Task<DriverReadDto?> CreateDriverAsync(Driver driver);
    }
}
