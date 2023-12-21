using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.Repositories.Interfaces;
using DVLD.DataAccess.Repositories.Implimentations;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<dbContextDVLD>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

new NationalityService(new dbContextDVLD(app.Configuration));

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
