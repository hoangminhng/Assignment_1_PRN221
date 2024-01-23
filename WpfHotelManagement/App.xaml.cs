using System;
using System.IO;
using System.Windows;
using Business.ViewModels;
using BusinessObject.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace WpfHotelManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection serviceCollection)
        {
            IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            
            Admin defaultUser = new Admin
            {
                EmailAddress = configuration["DefaultUser:EmailAddress"],
                Password = configuration["DefaultUser:Password"]
            };

            serviceCollection.AddSingleton<Admin>(defaultUser);

            serviceCollection.AddSingleton(typeof(ICustomerRepository), typeof(CustomerRepository));
            serviceCollection.AddSingleton(typeof(IBookingReservationRepository), typeof(BookingReservationRepository));

            serviceCollection.AddSingleton<MainWindow>();

            serviceCollection.AddSingleton<CustomerDashboard>();
            serviceCollection.AddSingleton<AdminDashboard>();
        }
        
        private void OnStartUp(Object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<AdminDashboard>();
            mainWindow.Show();
            //var loginWindow = _serviceProvider.GetService<LoginWindow>();
            //loginWindow.Show();
        }
    }
}