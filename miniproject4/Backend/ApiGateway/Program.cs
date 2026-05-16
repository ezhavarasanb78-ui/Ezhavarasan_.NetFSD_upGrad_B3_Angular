using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ApiGateway
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile(
                "ocelot.json",
                optional: false,
                reloadOnChange: true
            );

            builder.Services.AddControllers();
            builder.Services.AddOcelot();
            var app = builder.Build();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            await app.UseOcelot();

            app.Run();
        }
    }
}