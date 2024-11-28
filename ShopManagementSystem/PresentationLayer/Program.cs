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
using DataAccessLayer.Repositories.SuppliersRepo;
using BussinessLayer.Services.ServicesForSuppliers;
using DataAccessLayer.Repositories.PurchaseOrdersRepo;
using BussinessLayer.Services.ServicersForPurchaseOrders;
using DataAccessLayer.Repositories.ProductsRepo;
using BussinessLayer.Services.ServicesForProducts;
using DataAccessLayer.Repositories.SalesRepo;
using BussinessLayer.Services.ServicesForSales;

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
                    services.AddTransient<SalesreportForm>(); 
                    services.AddTransient<InventoryForm>();
                    services.AddTransient<CreateProductForm>();
                    services.AddTransient<PurchaseOrdersForm>();
                    services.AddTransient<RegisterSuppliersForm>();
                    services.AddTransient<ShoppingListForm>();
                    services.AddTransient<CatalogForm>();
                    services.AddTransient<RegisterClients>();
                    services.AddTransient<SalesreportForm>();

                    //Repositories
                    services.AddScoped<ILoginRepository,LoginRepository>();
                    services.AddScoped<IEmployeesRepository,EmployeeRepository>();
                    services.AddScoped<IInventoryRepository, InventoryRepository>();
                    services.AddScoped<ISuppliersRepository, SuppliersRepository>();
                    services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
                    services.AddScoped<IProductsRepository, ProductsRepository>();
                    services.AddScoped<ISalesRepository, SalesRepository>();

                    //Services
                    services.AddScoped<ILoginService,LoginService>();
                    services.AddScoped<IEmployeeService,EmployeesServices>();
                    services.AddScoped<IInventoryService, InventoryService>();
                    services.AddScoped<ISuppliersServices, SuppliersServices>();
                    services.AddScoped<IPurchaseOrdersServices, PurchaseOrdersServices>();
                    services.AddScoped<IProductsService, ProductsService>();
                    services.AddScoped<ISalesServices, SalesServices>();


                    //Connection
                    services.AddSingleton<ISqlConnect,SqlConnect>();

                    
                });
        }
    }
}