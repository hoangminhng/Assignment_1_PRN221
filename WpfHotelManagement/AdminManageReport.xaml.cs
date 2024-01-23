using System;
using System.Windows;
using System.Windows.Controls;
using BusinessObject.Models;
using Repository;

namespace WpfHotelManagement
{
    public partial class AdminManageReport : UserControl
    {
        private readonly BookingDetailRepository _bookingDetailRepository;
        public AdminManageReport()
        {
            InitializeComponent();
            IBaseRepository<BookingDetail> bookingDetailRepository = new BookingDetailRepository();
            _bookingDetailRepository = new BookingDetailRepository();
            dgCustomers.ItemsSource = bookingDetailRepository.GetAll();
        }

        private void BtnSearch_OnClick(object sender, RoutedEventArgs e)
        {
            DateTime? startDate = dtStartDate.SelectedDate;
            DateTime? endDate = dtEndDate.SelectedDate;

            if (startDate == null || endDate == null)
            {
                MessageBox.Show("Please select both start date and end date.");
                return;
            }

            DateTime startDateTime = startDate ?? DateTime.MinValue;
            DateTime endDateTime = endDate ?? DateTime.MaxValue;

            var bookingDetail = _bookingDetailRepository.GetByDateRange(startDateTime, endDateTime);
            dgCustomers.ItemsSource = bookingDetail;
        }
    }
}