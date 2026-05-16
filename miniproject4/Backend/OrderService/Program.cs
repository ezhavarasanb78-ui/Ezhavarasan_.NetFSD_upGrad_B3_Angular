using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.Repositories;
using OrderService.Services;
using System.Text.Json.Serialization;

namespace OrderService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder =
                WebApplication.CreateBuilder(args);

            // Add Controllers + Fix Circular Reference
            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler =
                        ReferenceHandler.IgnoreCycles;
                });

            // Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Database Connection
            builder.Services.AddDbContext<AppDbContext>(
                options =>
                    options.UseSqlServer(
                        builder.Configuration.GetConnectionString(
                            "DefaultConnection"
                        )
                    )
            );

            // CORS for Angular
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(
                    "AllowAngular",
                    policy =>
                    {
                        policy
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            builder.Services.AddScoped<
                IOrderRepository,
                OrderRepository>();

            builder.Services.AddScoped<
                IOrderService,
                Services.OrderService>();

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseCors("AllowAngular");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}