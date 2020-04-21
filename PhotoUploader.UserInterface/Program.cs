using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using PhotoUploader.UserInterface.Ioc;

namespace PhotoUploader.UserInterface
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            services.AddServices();
            services.AddForms();
            services.AddOptionsPattern();

            using var serviceProvider = services.BuildServiceProvider();

            Application.Run(services.BuildServiceProvider().GetRequiredService<Main>());
        }
    }
}
