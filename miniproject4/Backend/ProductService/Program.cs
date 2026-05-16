using Microsoft.EntityFrameworkCore;
using ProductService.Data;
using ProductService.Dapper;
using ProductService.Repositories;
using ProductService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService.Services.ProductService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("AllowAngular");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();