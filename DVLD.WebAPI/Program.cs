using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.Repositories.Interfaces;
using DVLD.DataAccess.Repositories.Implimentations;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.WebAPI.AuthService;
using DVLD.WebAPI.Repositories.Interfaces;
using DVLD.WebAPI.Repositories.Implimentations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IDriverRepository, DriverRepository>();
builder.Services.AddSingleton<IAuthService, AuthService>();
builder.Services.AddInstantAPIs();

builder.Services.AddAuthentication(Auth.Scheme.UserCookie)
    .AddCookie(Auth.Scheme.UserCookie)
    .AddCookie(Auth.Scheme.DriverCookie);

builder.Services.AddAuthorization(builder =>
{
    builder.AddPolicy(Auth.Policy.UserPolicy, p =>
    {
        p.AddAuthenticationSchemes(Auth.Scheme.UserCookie)
            .RequireAuthenticatedUser();
    });

    builder.AddPolicy(Auth.Policy.DriverPolicy, p =>
    {
        p.AddAuthenticationSchemes(Auth.Scheme.DriverCookie)
            .RequireAuthenticatedUser();
    });
});

var app = builder.Build();

#region SomeServiceBadInit

new NationalityService(new AppDbContext(app.Configuration));

#endregion

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run("https://localhost:4001");

