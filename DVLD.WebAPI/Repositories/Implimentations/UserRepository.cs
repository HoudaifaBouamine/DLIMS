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

        public async Task<UserReadDto?> ReadUser(int user_id)
        {
            UserReadDto? user = null;

            try
            {

                using var connection = new SqlConnection(_dbContextDVLD.ConnectionString);

                user = (await connection.QueryAsync<User, Person, UserReadDto>
                    (
                        "SELECT u.*,null as Sep,p.* " +
                        "FROM  Users u JOIN Persons p " +
                        "ON u.Person_Id = p.Person_Id " +
                        $"WHERE u.User_Id = {user_id}",
                        (user, person) =>
                        {
                            if (user is not null && person is not null)
                            {
                                return user.ToDto(person);
                            }

                            return null;
                        },
                        splitOn: "Sep"
                    )).FirstOrDefault();

            }
            catch (Exception ex)
            {
                string err = ex.Message;
                int x = 1;
            }

            return user;
        }

        public async Task<UserReadDto?> ReadUser(string userName, string password)
        {
            UserReadDto? userRead = null;

            try
            {

                using var connection = new SqlConnection(_dbContextDVLD.ConnectionString);
                var parameters = new { UserName = userName, Password = password };
                User? user = connection.Query<User>($"SELECT * FROM Users u WHERE u.UserName = @UserName AND Password = @Password", param: parameters).FirstOrDefault();

                if(user != null)
                {
                    userRead = await ReadUser(user.User_Id);
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                userRead = null;
                int x = 1;
            }

            

            return userRead;
        }

    }
}
