using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<UserReadDto?> ReadUser(int id);
        Task<UserReadDto?> ReadUserAsync(string userName,string password);
        Task<User?> CreateUser(User user);
    }
}
