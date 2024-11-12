using BussinessLayer.Services.ServicesForEmployees;
using BussinessLayer.Services.ServicesForLogin;
using CommonLayer.Entities;
using DataAccessLayer.dbConnect;
using DataAccessLayer.Repositories.EmployeesRepo;
using DataAccessLayer.Repositories.LoginRepo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresentationLayer.Forms;
using DataAccessLayer.Repositories.invetoryRepo;
using BussinessLayer.Services.ServicesForInventory;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    //Forms
                    services.AddTransient<LoginForm>();
                    services.AddTransient<DashboardForm>();
                    services.AddTransient<EmployeesForm>();
                    services.AddTransient<SalesForm>(); 
                    services.AddTransient<InventoryForm>();

                    //Repositories
                    services.AddScoped<ILoginRepository,LoginRepository>();
                    services.AddScoped<IEmployeesRepository,EmployeeRepository>();
                    services.AddScoped<IInventoryRepository, InventoryRepository>();

                    //Services
                    services.AddScoped<ILoginService,LoginService>();
                    services.AddScoped<IEmployeeService,EmployeesServices>();
                    services.AddScoped<IInventoryService, InventoryService>();


                    //Connection
                    services.AddSingleton<ISqlConnect,SqlConnect>();

                    
                });
        }
    }
}