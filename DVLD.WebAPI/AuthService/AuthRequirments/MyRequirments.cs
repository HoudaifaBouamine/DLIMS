using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace DVLD.WebAPI.AuthService.AuthRequirments
{
    public class MyRequirments: IAuthorizationRequirement
    {
    }



    public class MyRequirmentsHandler : AuthorizationHandler<MyRequirments>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext ctx, MyRequirments requirement)
        {
            return Task.CompletedTask;
        }
    }
}
