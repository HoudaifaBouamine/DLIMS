using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;

namespace DVLD.WebAPI.Repositories.Interfaces
{
    public interface IDriverRepository
    {
        Task<DriverReadDto?> ReadDriverAsync(int id);
        Task<DriverReadDto?> ReadDriverAsync(string email,string password);
    }
}
