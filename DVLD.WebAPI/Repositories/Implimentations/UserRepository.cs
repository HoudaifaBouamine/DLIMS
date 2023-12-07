using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.DataAccess.Repositories.Interfaces;
using DVLD.Models.Dtos.User;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.Repositories.Implimentations
{
    public class UserRepository : IUserRepository
    {
        private readonly dbContextDVLD _dbContextDVLD;
        public UserRepository(dbContextDVLD dbContextDVLD) 
        {
            this._dbContextDVLD = dbContextDVLD;
        }
        public Task<User?> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> ReadUser(int user_id)
        {
            return null;
        }

        public async Task<User?> ReadUserDto(int id)
        {
            return null;
        }
    }
}
