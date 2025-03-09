//using CheckStatusAPI.Data;
//using CheckStatusAPI.Data.Interfaces;
//using CheckStatusAPI.Data.Repositories;
//using CheckStatusAPI.Services.Interfaces;
//using CheckStatusAPI.Services.Implementations;
//using Microsoft.EntityFrameworkCore;


//var builder = WebApplication.CreateBuilder(args);

//// 1. Add services to the container
//// Configure EF Core with SQL Server
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//// Register repositories
//builder.Services.AddScoped<IUserRepository, UserRepository>();

//// Register services
//builder.Services.AddScoped<ICheckStatusService, CheckStatusService>();

//// Add controllers
//builder.Services.AddControllers();

//var app = builder.Build();

//// Enable serving static files and set index.html as the default page
//app.UseDefaultFiles(); // Serve index.html as the default page
//app.UseStaticFiles();  // Serve static files from wwwroot

//// 2. Configure the HTTP request pipeline
//app.MapControllers();

//app.Run();


using CheckStatusAPI.Data;
using CheckStatusAPI.Data.Interfaces;
using CheckStatusAPI.Data.Repositories;
using CheckStatusAPI.Services.Interfaces;
using CheckStatusAPI.Services.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Register services
builder.Services.AddScoped<ICheckStatusService, CheckStatusService>();

// Add controllers
builder.Services.AddControllers();

var app = builder.Build();

// Enable serving static files and set index.html as the default page
app.UseDefaultFiles(); // Serve index.html as the default page
app.UseStaticFiles();  // Serve static files from wwwroot

app.MapControllers();
app.Run();