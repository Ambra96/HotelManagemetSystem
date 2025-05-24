using System;
using System.Windows.Forms;
using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using HotelPmsCore.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HotelPmsCore
{
    internal static class Program
    {
    
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

           
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                {
                    
                    services.AddScoped<HotelPmsCoreContext>();
                 
                    services.AddScoped(typeof(MyBase<>), typeof(CrudServices<>));

                    services.AddScoped<HotelPmsCoreContext>();
                    services.AddScoped(typeof(MyBase<>), typeof(CrudServices<>));
                    services.AddScoped<CustomerService>();
                    services.AddScoped<CategoryServices>();
                    //services.AddScoped<RoomServices>();

                    // -- Forms
                    services.AddTransient<CustomerForm>();
                    services.AddTransient<CustomerEditForm>();
                    services.AddTransient<CategoryForm>();
                    services.AddTransient<CategoryEditForm>();
                    //services.AddTransient<RoomForm>();
                    services.AddTransient<RoomEditForm>();
                    services.AddTransient<LoginForm>();
                })
                .Build();

            ServiceProvider = host.Services;

            // 2) Show login as a dialog
            var loginForm = ServiceProvider.GetRequiredService<LoginForm>();
            var result = loginForm.ShowDialog();

            // 3) If login OK, run the main form; otherwise exit
            if (result == DialogResult.OK)
            {
                var main = ServiceProvider.GetRequiredService<MainForm>();
                Application.Run(main);
            }
            // else do nothing and let the process exit
        }
    }
}
