using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WebServiceFactoryInfrastructure.Database;

namespace WebServiceFactory.Extensions
{
    public static class ContextExtension
    {
        public static void AddContext(this IServiceCollection services, IConfiguration configuration)
        {
            var conSt = configuration.GetConnectionString("DockerConnection");

            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(conSt));
        }
    }

    public class StartupProjectContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DockerConnection");

            optionsBuilder.UseNpgsql(connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }

}
