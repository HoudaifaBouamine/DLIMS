using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using System.Security.Claims;

namespace DVLD.WebAPI.AuthService
{
    public class AuthService : IAuthService
    {
        public ClaimsPrincipal CreateClaimsPrincipal(UserReadDto userRead,string AuthSchem)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim("FirstName" ,userRead.Person.FirstName),
                new Claim("LastName"  ,userRead.Person.LastName),
                new Claim("Email"     ,userRead.Person.Email),
                new Claim("UserName"  ,userRead.UserName),
                new Claim("Permission",userRead.Permission.ToString())
            };
            ClaimsIdentity claimsIdentity = new(claims, AuthSchem);
            ClaimsPrincipal userClaimsPrincipal = new(claimsIdentity);

            return userClaimsPrincipal;
        }
    }

    public interface IAuthService
    {
        ClaimsPrincipal CreateClaimsPrincipal(UserReadDto userRead, string AuthSchem );
    }
}
