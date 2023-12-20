using Dapper;
using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.DataAccess.Repositories.Interfaces;
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
            using var connection = new SqlConnection(_dbContextDVLD.ConnectionStringName);
            User? user = (await connection.QueryAsync<User, Person, User>
                (
                    "SELECT u.*,null as Sep,p.* " +
                    "FROM  Users u JOIN Persons p " +
                    "ON u.Person_Id = p.Person_Id " +
                    $"WHERE u.User_Id = {user_id}",
                    (user,person) =>
                    {
                        user.Person = person;
                        return user;
                    },
                    splitOn:"Sep"
                )).FirstOrDefault();

            return user;
        }

        public async Task<User?> ReadUserDto(int id)
        {
            return null;
        }
    }
}
