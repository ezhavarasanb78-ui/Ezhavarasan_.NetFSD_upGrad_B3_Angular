using Contactservice.Data;
using Contactservice.Repositories;
using Contactservice.Services;
using Microsoft.EntityFrameworkCore;

namespace Contactservice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 🔹 Add Controllers
            builder.Services.AddControllers();

            // 🔹 Swagger (better than AddOpenApi)
            builder.Services.AddEndpointsApiExplorer();
            

            // 🔹 Database Configuration
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")
                ));

            // 🔹 Dependency Injection
            builder.Services.AddScoped<IContactRepository, ContactRepository>();
            builder.Services.AddScoped<IContactService, ContactService>();

            var app = builder.Build();

            // 🔹 Middleware Pipeline
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}