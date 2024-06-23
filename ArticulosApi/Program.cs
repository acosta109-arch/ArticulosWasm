
using Ap1_P1_JairoCamilo.DAL;
using Microsoft.EntityFrameworkCore;

namespace ArticulosApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Inyección del contexto
            var ConStr = builder.Configuration.GetConnectionString("ConStr");
            builder.Services.AddDbContext<Contexto>(c => c.UseSqlite(ConStr));

            var app = builder.Build();

            // Configure the HTTP request pipeline.

                app.UseSwagger();
                app.UseSwaggerUI();

            //LINEAS NUEVAS PARA ACTIVAR EL CORD
            app.UseCors(options =>
            {
                options.AllowAnyOrigin(); // Permitir solicitudes desde cualquier origen
                options.AllowAnyHeader(); // Permitir cualquier encabezado
                options.AllowAnyMethod(); // Permitir cualquier método HTTP
            });

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
