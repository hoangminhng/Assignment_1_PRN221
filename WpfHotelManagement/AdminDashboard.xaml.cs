using System;
using System.Windows;

namespace WpfHotelManagement
{
    public partial class AdminDashboard : Window
    {
        public AdminDashboard()
        {
            InitializeComponent();
            mainContent.Content = new AdminManageCustomerInfo();
        }

        private void ManageCustomer_Onclick(object sender, RoutedEventArgs e)
        {
            mainContent.Content = new AdminManageCustomerInfo();
        }
        
        private void ManageRooms_Onclick(object sender, RoutedEventArgs e)
        {
            mainContent.Content = new AdminManageRoom();
        }
        
        private void ManageReservations_Onclick(object sender, RoutedEventArgs e)
        {
            mainContent.Content = new AdminManageReservation();
        }
        
        private void ManageReport_Onclick(object sender, RoutedEventArgs e)
        {
            mainContent.Content = new AdminManageReport();
        }
        
        private void Logout_OnClick(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}