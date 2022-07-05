using Microsoft.EntityFrameworkCore;
using RestaurantAPI2.Data;
using RestaurantAPI2.Models;
using RestaurantAPI2.Repository;
using Microsoft.AspNetCore.Authentication;
using RestaurantAPI2.Handler;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(typeof(IRepository<Branch>), typeof(BranchRepository));
builder.Services.AddScoped(typeof(IRepository<Customer>), typeof(CustomerRepository));
builder.Services.AddScoped(typeof(IRepository<Order>), typeof(OrderRepository));
builder.Services.AddScoped(typeof(IRepository<Dish>), typeof(DishRepository));
builder.Services.AddScoped(typeof(IRepository<Employee>), typeof(EmployeeRepository));
builder.Services.AddScoped(typeof(IRepository<Owner>), typeof(OwnerRepository));
builder.Services.AddScoped(typeof(IRepository<Restaurant>), typeof(RestaurantRepository));  

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions,BasicAuthenticationHandler>("BasicAuthentication", null);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
