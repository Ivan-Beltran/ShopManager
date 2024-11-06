using BussinessLayer.Services;
using CommonLayer.Entities;
using DataAccessLayer.dbConnect;
using DataAccessLayer.Repositories;


using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresentationLayer.Forms;

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
                    services.AddTransient<ViewEmployeesForm>();
                    services.AddTransient<SalesForm>(); 

                    //Repositories
                    services.AddScoped<ILoginRepository,LoginRepository>();
                    services.AddScoped<IEmployeesRepository,EmployeeRepository>();  
                    

                    //Services
                    services.AddScoped<ILoginService,LoginService>();
                    services.AddScoped<IEmployeeService,EmployeesServices>();
                    

                    //Connection
                    services.AddSingleton<ISqlConnect,SqlConnect>();

                    
                });
        }
    }
}