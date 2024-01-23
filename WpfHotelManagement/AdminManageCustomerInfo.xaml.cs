using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BusinessObject.Models;
using Repository;

namespace WpfHotelManagement
{
    public partial class AdminManageCustomerInfo : UserControl
    {
        private readonly IBaseRepository<Customer> _customerRepository;
        private readonly IBaseRepository<BookingReservation> _bookingReservationRepository;

        public AdminManageCustomerInfo()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
            _bookingReservationRepository = new BookingReservationRepository();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgCustomers.ItemsSource = _customerRepository.GetAll();
        }

        private void DgCustomers_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var customer = dgCustomers.SelectedItem as Customer;
            if (customer != null)
            {
                txtCustomerId.Text = customer.CustomerId.ToString();
                txtCustomerFullName.Text = customer.CustomerFullName;
                txtEmailAddress.Text = customer.EmailAddress;
                txtTelephone.Text = customer.Telephone;
                dtBirthday.SelectedDate = customer.CustomerBirthday;
                txtPassword.Text = customer.Password;
            }
        }

        private bool checkNullOrEmpty()
        {
            bool nullOrEmpty = true;
            if (string.IsNullOrEmpty(txtCustomerFullName.Text) || string.IsNullOrEmpty(txtEmailAddress.Text) ||
                string.IsNullOrEmpty(txtTelephone.Text) || !dtBirthday.SelectedDate.HasValue)
            {
                nullOrEmpty = true;
            }
            else
            {
                nullOrEmpty = false;
            }

            return nullOrEmpty;
        }

        private void BtnCreate_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                bool nullOrEmpty = checkNullOrEmpty();
                if (nullOrEmpty)
                {
                    MessageBox.Show("Please fill all required fields", "Warning", MessageBoxButton.OK);
                }
                else
                {
                    Customer customer = new Customer
                    {
                        CustomerFullName = txtCustomerFullName.Text,
                        EmailAddress = txtEmailAddress.Text,
                        CustomerBirthday = dtBirthday.SelectedDate,
                        Telephone = txtTelephone.Text,
                    };
                    bool created = _customerRepository.Create(customer);
                    if (created)
                    {
                        LoadCustomers();
                        MessageBox.Show("Customer has been created", "Warning", MessageBoxButton.OK);
                    }
                    else
                    {
                        MessageBox.Show("Fall to create", "Warning", MessageBoxButton.OK);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void BtnUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                bool nullOrEmpty = checkNullOrEmpty();
                if (nullOrEmpty == true)
                {
                    MessageBox.Show("Please fill all required fields", "Warning", MessageBoxButton.OK);
                }
                else
                {
                    var customer = dgCustomers.SelectedItem as Customer;
                    Customer existingCustomer = _customerRepository.GetById(customer.CustomerId);
                    bool updated = false;

                    if (existingCustomer != null)
                    {
                        existingCustomer.Telephone = txtTelephone.Text;
                        existingCustomer.EmailAddress = txtEmailAddress.Text;
                        existingCustomer.CustomerFullName = txtCustomerFullName.Text;
                        existingCustomer.CustomerBirthday = dtBirthday.SelectedDate;

                        updated = _customerRepository.Update(existingCustomer);
                    }

                    if (updated)
                    {
                        LoadCustomers();
                        MessageBox.Show("Customer has been updated", "Success", MessageBoxButton.OK);
                    }
                    else
                    {
                        MessageBox.Show("Fall to create", "Warning", MessageBoxButton.OK);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            var customer = dgCustomers.SelectedItem as Customer;
            Customer existingCustomer = _customerRepository.GetById(customer.CustomerId);
            if (existingCustomer != null)
            {
                var bookingList = _bookingReservationRepository.GetAll().Where(x => x.CustomerId == existingCustomer.CustomerId)
                    .ToList().Count;
                if (bookingList > 0)
                {
                    MessageBox.Show("Customer has booking reservation, status change to 0", "Warning", MessageBoxButton.OK);
                    existingCustomer.CustomerStatus = 0;
                    _customerRepository.Update(existingCustomer);
                    LoadCustomers();
                }
                else
                {
                    MessageBoxResult confirm =
                        MessageBox.Show("Are you sure want to delete?", "Warning", MessageBoxButton.YesNo);
                    if (confirm == MessageBoxResult.Yes)
                    {
                        bool deleted = _customerRepository.Delete(existingCustomer);
                        LoadCustomers();
                        if (deleted)
                        {
                            MessageBox.Show("Customer has been deleted", "Warning", MessageBoxButton.OK);
                        }
                        else
                        {
                            MessageBox.Show("Fall to update", "Warning", MessageBoxButton.OK);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Product not found", "Warning", MessageBoxButton.OK);
            }
        }
    }
}