using System;
using System.Windows.Forms;
using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using HotelPmsCore.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HotelPmsCore
{
    internal static class Program
    {
        /// <summary>
        /// The global service provider, set up at startup.
        /// </summary>
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Build the Host with DI
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                {
                    // 1) DbContext (reads OnConfiguring)
                    services.AddScoped<HotelPmsCoreContext>();

                    // 2) Data services
                    services.AddScoped(typeof(MyBase<>), typeof(CrudServices<>));
                   // services.AddScoped(typeof(PageCrudServices<>));

                    // 3) Forms
                    services.AddTransient<LoginForm>();
                    services.AddTransient<MainForm>();
                    services.AddTransient<CustomerForm>();
                    services.AddTransient<CategoryForm>();
                    services.AddTransient<RoomForm>();
                })
                .Build();

            // Save the provider for later resolution
            ServiceProvider = host.Services;

            // Run the app starting at LoginForm
            var login = ServiceProvider.GetRequiredService<LoginForm>();
            Application.Run(login);
        }
    }
}
