using Microsoft.EntityFrameworkCore;
using System;
using WebApiDockerDemo.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var conString = builder.Configuration.GetConnectionString("PlantsConnection");
builder.Services.AddDbContext<OnlineShopDbContext>(options =>
    options.UseSqlServer(conString));



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
