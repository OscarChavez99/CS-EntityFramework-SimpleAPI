using CS_EntityFramework_SimpleAPI.Repositories;
using CS_EntityFramework_SimpleAPI.Repositories.DBContexts;
using CS_EntityFramework_SimpleAPI.Repositories.Interfaces;
using CS_EntityFramework_SimpleAPI.Services;
using CS_EntityFramework_SimpleAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Entity Framework & ConnectionString configuration
builder.Services.AddDbContext<AppDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Injected
builder.Services.AddScoped<IStudentService , StudentService>();
builder.Services.AddScoped<IStudentRepository , StudentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
