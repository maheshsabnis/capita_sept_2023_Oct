using Core_API.CustomFilters;
using Core_API.CustomMIddlewares;
using Core_API.Models;
using Core_API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// DI COntainer

// 1. Register the UcompanyDbContext

builder.Services.AddDbContext<UcompanyContext>(options => 
{
    // builder.Configuration: This will Read the appsettngs.json file in Project
    // builder.Configuration.GetConnectionString(""): Will read the 'ConnectionStrings' section
    // for the appsettngs.json file
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString"));
});

// 2. Lets register Repositories
builder.Services.AddScoped<IDataAccessRepository<Department,int>, DepartmentDataAccessRepository>();

builder.Services.AddScoped<IDataResponseService<Employee,int>,EmployeeDataAccessRepository>();

// 3. Define Cross-Origin-Resource-Sharing (CORS) Service
// 3.1. The Allowed Origin THat can call the API
// 3.2. The Allowed HTTP Request Meathod that can call API from the Origin
// 3.3. The Allowed HTTP Request Header that MUST be present in Http Request to API from the Origin 
builder.Services.AddCors(options => 
{
    options.AddPolicy("corspolicy", policy => 
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});



// The Registration for API Controller Request Proessing
builder.Services.AddControllers() // Configure the Response as Pascal Case instead of Camel Case
      .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null)
      // Filter at the GLobal Scope
      // THis will always Preceeds the Middleware for MVC and API Controllers
      .AddMvcOptions(options=>options.Filters.Add(new LoggerFilterAttribute()));
        


// For MVC
builder.Services.AddControllersWithViews();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Http to Https Redirection MApping
app.UseHttpsRedirection();
// Add CORS Middlweare that will execute the Policy
app.UseCors("corspolicy");


// FOr MVC View
app.UseRouting();

// Apply the Custom Middleware

app.UseErrorExtender();


// Use of Authorization
app.UseAuthorization();
// Map the Request to the API Controller
// INtenally uses the ROuting
// https://localhost:PORT/Department
app.MapControllers();
// FOr MVC View
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Client}/{action=Index}/{id?}");

// Run the Application
// Start the HTTP Request Processing
app.Run();
