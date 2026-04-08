using WebAPI.DataAccess;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ✅ Add services to the container
            builder.Services.AddControllers();

            // ✅ Dependency Injection (Repository)
            builder.Services.AddSingleton<IContactRepository, ContactRepository>();

            // ✅ Swagger (API Testing UI)
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // ✅ Configure Middleware
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();     // Enable Swagger JSON
                app.UseSwaggerUI();   // Enable Swagger UI
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}