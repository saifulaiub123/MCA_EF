using System.Reflection;
using MCA_EF.Core.Interface.IService;
using MCA_EF.Core.Mapping;
using MCA_EF.Core.Service;
using MCA_EF.Data.DbContext;
using MCA_EF_API.Seeder;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json",
        optional: true);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnectionString"),
        sqlServerOptions => sqlServerOptions.UseNetTopologySuite());
});
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(FormMapping)));
builder.Services.AddScoped<IFormService, FormService>();

var app = builder.Build();


await DBSeeder.Seed(app);


app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseCors();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
