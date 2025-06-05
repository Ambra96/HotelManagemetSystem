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
                    services.AddScoped<CustomerService>();
                    services.AddScoped<CategoryService>();
                    services.AddScoped<RoomService>();
                    //services.AddScoped<ReservationService>();
                    services.AddScoped<PeriodService>();
                    services.AddScoped<UserService>();
                    services.AddScoped<StaffService>();
                    services.AddScoped<Argon2>();
                    services.AddScoped<DataSeed>();

                    // -- Forms
                    services.AddTransient<MainForm>();
                    services.AddTransient<CustomerForm>();
                    services.AddTransient<CustomerEditForm>();
                    services.AddTransient<CustomerFilter>();
                    services.AddTransient<CategoryForm>();
                    services.AddTransient<CategoryEditForm>();
                    services.AddTransient<CategoryFilter>();
                    services.AddTransient<RoomForm>();
                    services.AddTransient<RoomEditForm>();
                    services.AddTransient<RoomFilter>();
                    //services.AddTransient<ReservationForm>();
                    //services.AddTransient<ReservationEditForm>();
                    // services.AddTransient<ReservationFilter>();
                    services.AddTransient<PeriodForm>();
                    services.AddTransient<PeriodEditForm>();
                    services.AddTransient<PeriodFilter>();
                    services.AddTransient<UserForm>();
                    services.AddTransient<UserEditForm>();
                    services.AddTransient<UserFilter>();
                    services.AddTransient<StaffForm>();
                    services.AddTransient<StaffEditForm>();
                    services.AddTransient<StaffFilter>();
                    services.AddTransient<LoginForm>();
                    services.AddDbContext<HotelPmsCoreContext>();
                  
                })
                .Build();

            ServiceProvider = host.Services;

            using (var scope = ServiceProvider.CreateScope())
            {
                scope.ServiceProvider
                     .GetRequiredService<DataSeed>()
                     .Seed();
            }



            // show login
            var login = ServiceProvider.GetRequiredService<LoginForm>();
            if (login.ShowDialog() == DialogResult.OK)
            {
             
                var main = ServiceProvider.GetRequiredService<MainForm>();
                Application.Run(main);
            }

        }
    }
}
