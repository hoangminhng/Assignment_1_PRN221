using System;
using System.Windows;
using System.Windows.Controls;
using BusinessObject.Models;
using Repository;

namespace WpfHotelManagement
{
    public partial class CustomerProfile : UserControl
    {
        private readonly int customerId;
        private Customer customer;
        private readonly IBaseRepository<Customer> _customerRepository;

        public CustomerProfile(int customerId)
        {
            this.customerId = customerId;
            InitializeComponent();
            _customerRepository = new CustomerRepository();
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            customer = _customerRepository.GetById(customerId);
            txtTelephone.Text = customer.Telephone;
            txtEmailAddress.Text = customer.EmailAddress;
            txtCustomerFullName.Text = customer.CustomerFullName;
            dtBirthday.SelectedDate = customer.CustomerBirthday;
        }
        public void getDataToUpdate(int accountId)
        {
            bool check = false;

            if (String.IsNullOrEmpty(txtCustomerFullName.Text) || String.IsNullOrEmpty(txtEmailAddress.Text) || String.IsNullOrEmpty(txtTelephone.Text))
            {
                MessageBox.Show("Please fill in all the field", "Error", MessageBoxButton.OK);
                return;
            }

            customer.CustomerFullName = txtCustomerFullName.Text;
            customer.EmailAddress = txtEmailAddress.Text;
            customer.Telephone = txtTelephone.Text;
            customer.CustomerBirthday = dtBirthday.SelectedDate;

            check = _customerRepository.Update(customer);
            if (check)
            {
                MessageBox.Show("Update Success", "Notification", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Update failed", "Error", MessageBoxButton.OK);
            }

            LoadCustomer();

        }
        private void BtnUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            getDataToUpdate(customerId);
        }
    }
}