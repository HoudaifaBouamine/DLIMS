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
        Task<User?> ReadUser(int id);
        Task<User?> ReadUserDto(int id);
        Task<User?> CreateUser(User user);
    }
}
