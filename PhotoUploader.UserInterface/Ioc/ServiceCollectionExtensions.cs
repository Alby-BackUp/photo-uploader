using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PhotoUploader.UserInterface.Gateways;
using PhotoUploader.UserInterface.Options;

namespace PhotoUploader.UserInterface.Ioc
{
    public static class ServiceCollectionExtensions
    {
        public static void AddForms(this IServiceCollection services)
        {
            services.AddSingleton<Main>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IMatteoWritingGateway, MatteoWritingGateway>();
        }

        public static void AddOptionsPattern(this IServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);

            var config = builder.Build();

            services.Configure<ConnectionStrings>(config.GetSection("ConnectionStrings"));
        }
    }
}
