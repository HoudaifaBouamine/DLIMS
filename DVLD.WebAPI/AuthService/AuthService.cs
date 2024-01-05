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
                new Claim("Id"          ,driverRead.Driver_Id.ToString()),
                new Claim("FirstName"   ,driverRead.Person!.FirstName),
                new Claim("LastName"    ,driverRead.Person.LastName),
                new Claim("Email"       ,driverRead.Person.Email),
            };
            ClaimsIdentity claimsIdentity = new(claims, AuthSchem);
            ClaimsPrincipal userClaimsPrincipal = new(claimsIdentity);

            return userClaimsPrincipal;
        }

        public ClaimsPrincipal CreateUserClaimsPrincipal(UserReadDto userRead,string AuthSchem)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim("Id",userRead.User_Id.ToString()),
                new Claim("FirstName" ,userRead.Person.FirstName),
                new Claim("LastName"  ,userRead.Person.LastName),
                new Claim("Email"     ,userRead.Person.Email),
                new Claim("UserName"  ,userRead.UserName),
                new Claim("Permission",userRead.Permission.ToString()),
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
