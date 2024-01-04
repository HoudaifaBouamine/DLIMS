using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.Repositories.Interfaces;
using DVLD.DataAccess.Repositories.Implimentations;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DVLD.WebAPI.AuthService;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<dbContextDVLD>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IAuthorizationHandler, MyRequirmentsHandler>();
builder.Services.AddAuthentication(Policies.AuthSheme)
    .AddCookie(Policies.AuthSheme);

builder.Services.AddAuthorization(builder =>
{
    builder.AddPolicy(Policies.HaveUserName, p =>
    {
        p.RequireAuthenticatedUser()
            .AddAuthenticationSchemes(Policies.AuthSheme)
            .RequireClaim("UserName");
    });

    builder.AddPolicy(Policies.HavePermissionValue2OrMore, p =>
    {
        p.RequireAuthenticatedUser()
        .AddAuthenticationSchemes(Policies.AuthSheme)
        .RequireClaim("Permission")
        .RequireAssertion((ctx) =>
        {
            int permission = Convert.ToInt32( ctx.User.FindFirstValue("Permission"));
            if(permission >= 2)
            {
                return true;
            }
            return false;
        });
    });

    builder.AddPolicy(Policies.AuthRequirmentTest, p =>
    {

        p.RequireAuthenticatedUser()
            .AddAuthenticationSchemes(Policies.AuthSheme)
            .AddRequirements(new MyRequirments());
    });
});



var app = builder.Build();

new NationalityService(new dbContextDVLD(app.Configuration));

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapPost("/login", async (IUserRepository userRepo, HttpContext ctx, [FromBody] UserLoginDto userLogin) =>
{
    string userName = userLogin.UserName;
    string password = userLogin.Password;

    var user = await userRepo.ReadUserAsync(userName, password);

    if(user == null)
    {
        return Results.BadRequest("Failed To Login");
    }

    List<Claim> claims = new List<Claim> 
    {
        new Claim("FirstName",user.Person.FirstName),
        new Claim("LastName" ,user.Person.LastName),
        new Claim("Email"    ,user.Person.Email),
        new Claim("UserName",user.UserName),
        new Claim("Permission",user.Permission.ToString())
    };
    ClaimsIdentity claimsIdentity = new(claims,Policies.AuthSheme);
    ClaimsPrincipal claimsPrincipal = new(claimsIdentity);

    await ctx.SignInAsync(Policies.AuthSheme, claimsPrincipal);

    return Results.Ok("Login Successfuly");
});

app.MapGet("/logout", async (HttpContext ctx) =>
{
    await ctx.SignOutAsync(Policies.AuthSheme);

    return Results.Ok("Logout Successfuly");
});

app.MapGet("/user", (HttpContext ctx) =>
{

    var email = ctx.User.FindFirstValue("Email");

    if(email is null)
    {
        return "No User";
    }

    return email;
});

app.MapGet("/user/auth", (HttpContext ctx) =>
{
    var email = ctx.User.FindFirstValue("Email");

    if (email is null)
    {
        return "No User";
    }

    return email;
}).RequireAuthorization(Policies.HaveUserName);

app.MapGet("/user/auth/permission", (HttpContext ctx) =>
{
    var email = ctx.User.FindFirstValue("Email");

    if (email is null)
    {
        return "No User";
    }

    return email;
}).RequireAuthorization(Policies.HavePermissionValue2OrMore);


app.MapGet("/user/auth/requirments", (HttpContext ctx) =>
{
    var email = ctx.User.FindFirstValue("Email");

    if (email is null)
    {
        return "No User";
    }

    return "Only you can see this " + email;
}).RequireAuthorization(Policies.AuthRequirmentTest);

app.MapGet("/any", () =>
{
    return "any one can see this";
});

app.MapControllers();

app.Run();


public class MyRequirments : IAuthorizationRequirement
{
    
}

public class MyRequirmentsHandler : AuthorizationHandler<MyRequirments>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext ctx, MyRequirments requirement)
    {

        var email = ctx.User.FindFirstValue("Email");
        if(email is null)
        {
            ctx.Fail();
            return Task.CompletedTask;
        }


        if(email == "john.doe@example.com")
        {
            ctx.Succeed(requirement);
            return Task.CompletedTask;

        }

        
        ctx.Fail();
        return Task.CompletedTask;
    }
}