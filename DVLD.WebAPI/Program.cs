using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.Repositories.Interfaces;
using DVLD.DataAccess.Repositories.Implimentations;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

string AuthSheme = "cookie";

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<dbContextDVLD>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddAuthentication(AuthSheme)
    .AddCookie(AuthSheme);

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
        new Claim("UserName",user.UserName)
    };
    ClaimsIdentity claimsIdentity = new(claims,AuthSheme);
    ClaimsPrincipal claimsPrincipal = new(claimsIdentity);

    await ctx.SignInAsync(AuthSheme,claimsPrincipal);

    return Results.Ok("Login Successfuly");
});

app.MapGet("/logout", async (HttpContext ctx) =>
{
    await ctx.SignOutAsync(AuthSheme);

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

app.MapControllers();

app.Run();
