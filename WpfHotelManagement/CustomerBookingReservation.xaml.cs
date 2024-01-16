using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using BusinessObject.Models;
using Repository;

namespace WpfHotelManagement
{
    public partial class CustomerBookingReservation : UserControl
    {
        private readonly IBaseRepository<BookingReservation> _bookingReservationRepository;
        private int customerId;
        public CustomerBookingReservation(int customerId)
        {
            _bookingReservationRepository = new BookingReservationRepository();
            this.customerId = customerId;
            InitializeComponent();
            LoadCustomerBooking();
        }

        public void LoadCustomerBooking()
        {
            var listBooking = _bookingReservationRepository.GetAll().Where(x => x.CustomerId == customerId).Select(booking => new
            {
                BookingReservationId = booking.BookingReservationId,
                BookingDate = booking.BookingDate,
                TotalPrice = booking.TotalPrice,
                BookingStatus = booking.BookingStatus
            }).ToList();
            
            dgBooking.ItemsSource = listBooking;
        }
    }
}