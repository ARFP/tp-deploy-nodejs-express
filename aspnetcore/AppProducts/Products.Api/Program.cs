
using Microsoft.EntityFrameworkCore;
using Products.Api.Db;

namespace Products.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            /*
            // r�cup�rer la chaine de connexion � partir du fichier appsettings.json
            var connectionString = builder.Configuration.GetConnectionString("productConnection");
            // Utiliser cette chaine de connexion dans notre DbContext.
            builder.Services.AddDbContext<ProductsDbContext>(options => options.UseSqlServer(connectionString));
            */
            builder.Services.AddDbContext<ProductsDbContext>();

            builder.Services.AddControllers();
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
