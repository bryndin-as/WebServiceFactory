
using Microsoft.EntityFrameworkCore;
using WebServiceFactory.Extensions;
using WebServiceFactoryContracts.Repositories;
using WebServiceFactoryInfrastructure.Database;
using WebServiceFactoryInfrastructure.Entities;
using WebServiceFactoryInfrastructure.Repositories;
using WebServiceFactoryInfrastructure.Services;

namespace WebServiceFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Настраиваем логгирование программно
            builder.Logging.ClearProviders(); // Опционально: очищаем стандартных провайдеров
            builder.Logging.AddConsole(); // Добавляем логирование в консоль
            builder.Logging.AddDebug(); // Добавляем логирование в отладочный вывод

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //builder.Services.AddDbContext<AppDbContext>();

            builder.Services.AddContext(builder.Configuration);

            //builder.Services.AddDbContext<AppDbContext>(options =>
            //{
            //    string a = "Host=postgresw;Port=5432;Database=;Username=root;Password=111QQQwww";
            //    Console.WriteLine(a);
            //    options.UseNpgsql(a);
            //});

            

            builder.Services.AddScoped<IDataTestRepository, DataTestRepository>();
            builder.Services.AddScoped<FillerBd>();


            var app = builder.Build();

            //Update db
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<AppDbContext>();
                if (context.Database.GetPendingMigrations().Any())
                    context.Database.Migrate();
            }

            


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
