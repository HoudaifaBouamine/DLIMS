using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using System.Security.Claims;

namespace DVLD.WebAPI.AuthService
{
    public class AuthService : IAuthService
    {
        public ClaimsPrincipal CreateDriverClaimsPrincipal(DriverReadDto driverRead, string AuthSchem)
        {
            List<Claim> claims = new List<Claim>
            {
                new ("Id"          ,driverRead.Driver_Id.ToString()),
                new ("FirstName"   ,driverRead.Person!.FirstName),
                new ("LastName"    ,driverRead.Person.LastName),
                new ("Email"       ,driverRead.Person.Email),
            };
            ClaimsIdentity claimsIdentity = new(claims, AuthSchem);
            ClaimsPrincipal userClaimsPrincipal = new(claimsIdentity);

            return userClaimsPrincipal;
        }

        public ClaimsPrincipal CreateUserClaimsPrincipal(UserReadDto userRead,string AuthSchem)
        {
            List<Claim> claims = new List<Claim>
            {
                new ("Id",userRead.User_Id.ToString()),
                new ("FirstName" ,userRead.Person.FirstName),
                new ("LastName"  ,userRead.Person.LastName),
                new ("Email"     ,userRead.Person.Email),
                new ("UserName"  ,userRead.UserName),
                new ("Permission",userRead.Permission.ToString()),
            };
            ClaimsIdentity claimsIdentity = new(claims, AuthSchem);
            ClaimsPrincipal userClaimsPrincipal = new(claimsIdentity);

            return userClaimsPrincipal;
        }
    }

    public interface IAuthService
    {
        ClaimsPrincipal CreateUserClaimsPrincipal(UserReadDto userRead, string AuthSchem );
        ClaimsPrincipal CreateDriverClaimsPrincipal(DriverReadDto driverRead, string AuthSchem );
    }
}
