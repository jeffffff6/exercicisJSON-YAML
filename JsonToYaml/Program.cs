using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace JsonToYamlApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Agregar los servicios necesarios para las API REST
            builder.Services.AddControllers();

            var app = builder.Build();

            // Configurar las rutas para las API
            app.MapControllers();

            // Iniciar la API
            app.Run();
        }
    }
}
