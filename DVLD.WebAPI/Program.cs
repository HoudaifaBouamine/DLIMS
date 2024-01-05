using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.Repositories.Interfaces;
using DVLD.DataAccess.Repositories.Implimentations;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.WebAPI.AuthService;
using System.Net.Mime;
using System.Text;
using Fritz.InstantAPIs;
using DVLD.WebAPI.Repositories.Interfaces;
using DVLD.WebAPI.Repositories.Implimentations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<dbContextDVLD>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IDriverRepository, DriverRepository>();
builder.Services.AddSingleton<IAuthService, AuthService>();
builder.Services.AddInstantAPIs();

builder.Services.AddAuthentication(Auth.UserCookie)
    .AddCookie(Auth.UserCookie)
    .AddCookie(Auth.DriverCookie);

builder.Services.AddAuthorization(builder =>
{
    builder.AddPolicy(Auth.UserPolicy, p =>
    {
        p.AddAuthenticationSchemes(Auth.UserCookie)
            .RequireAuthenticatedUser();
    });

    builder.AddPolicy(Auth.DriverPolicy, p =>
    {
        p.AddAuthenticationSchemes(Auth.DriverCookie)
            .RequireAuthenticatedUser();
    });
});

var app = builder.Build();

#region SomeServiceBadInit

new NationalityService(new dbContextDVLD(app.Configuration));

#endregion

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();

