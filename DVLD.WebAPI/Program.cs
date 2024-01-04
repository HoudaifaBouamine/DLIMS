using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.Repositories.Interfaces;
using DVLD.DataAccess.Repositories.Implimentations;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.WebAPI.AuthService;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using Microsoft.AspNetCore.Http;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<dbContextDVLD>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IAuthService, AuthService>();

builder.Services.AddAuthentication(Auth.Cookie)
    .AddCookie(Auth.Cookie);

builder.Services.AddAuthorization(builder =>
{
    builder.AddPolicy(Auth.UserPolicy, p =>
    {
        p.AddAuthenticationSchemes(Auth.Cookie)
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

Uri url = new Uri("https://localhost:3030");


// This is the root page that will re-direct the client to api the documentation
app.MapGet("/", (HttpContext ctx) => 
{
    ctx.Response.ContentType = MediaTypeNames.Text.Html;
    var _html = "<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n " +
    "   <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n  " +
    "  <title>Document</title>\r\n</head>\r\n<body>\r\n  " +
    "  <h1>You can fined the documentation" +
    $" <a href=\"{url.ToString()}swagger\">here</a>" +
    "</h1>\r\n</body>\r\n</html>";

    ctx.Response.ContentLength = Encoding.UTF8.GetByteCount(_html);
    return ctx.Response.WriteAsync(_html);
});

app.MapControllers();

app.Run(url.ToString());

