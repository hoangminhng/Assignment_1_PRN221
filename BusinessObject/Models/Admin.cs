using System.Collections.Generic;
using BusinessObject.Models;

namespace Business.ViewModels
{
    public class AdminFileData
    {
        public Admin DefaultUser { get; set; }
    }

    public class Admin
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
    
    public class AdminManageCustomerInfoViewModel
    {
        public List<Customer> Customers { get; set; }

        public AdminManageCustomerInfoViewModel(List<Customer> customers)
        {
            Customers = customers;
        }
    }
}