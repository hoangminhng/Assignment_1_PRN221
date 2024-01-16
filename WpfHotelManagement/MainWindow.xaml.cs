using System;
using System.Linq;
using System.Windows;
using BusinessObject.Models;
using Repository;

namespace WpfHotelManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IBaseRepository<Customer> _customerRepository;
        private readonly IAdminRepository _adminRepository;

        public MainWindow()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
            _adminRepository = new AdminRepository();
        }

        private void BtnLogin_OnClick(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            try
            {
                if (String.IsNullOrEmpty(username) && String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill all required fields", "Warning", MessageBoxButton.OK);
                }
                else
                {
                    var admin = _adminRepository.GetAdminViewModel();
                    var customers = _customerRepository.GetAll();
                    if (username == admin.EmailAddress && password == admin.Password)
                    {
                        this.Visibility = Visibility.Collapsed;
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                    }
                    else
                    {
                        var customer = customers.First(x => x.EmailAddress == username);
                        if (password == customer.Password)
                        {
                            int customerId = customer.CustomerId;
                            this.Visibility = Visibility.Collapsed;
                            CustomerDashboard customerDashboard = new CustomerDashboard(customerId);
                            customerDashboard.Show();
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                /*Console.WriteLine(exception);*/
                MessageBox.Show("login failed", "Error", MessageBoxButton.OK);
                /*throw;*/
            }
        }
    }
}