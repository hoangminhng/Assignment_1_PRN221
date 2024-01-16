using System.Windows;

namespace WpfHotelManagement
{
    public partial class CustomerDashboard : Window
    {
        private int customerId;
        public CustomerDashboard(int customerId)
        {
            this.customerId = customerId;
            InitializeComponent();
            mainContent.Content = new CustomerProfile(customerId);
        }

        private void ManageProfile_Onclick(object sender, RoutedEventArgs e)
        {
            mainContent.Content = new CustomerProfile(customerId);
        }
        
        private void ManageBooking_Onclick(object sender, RoutedEventArgs e)
        {
            mainContent.Content = new CustomerBookingReservation(customerId);
        }

        private void Logout_OnClick(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}