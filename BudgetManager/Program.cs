using BudgetManager.Data.Interfaces;
using BudgetManager.Models;
using BudgetManager.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRouting(option => option.LowercaseUrls = true);
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddControllers();

// Database connection 
builder.Services.AddDbContextPool<BudgetContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("BudgetManagerContextConnectionString")));
builder.Services.AddScoped<IUserData, UserData>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
