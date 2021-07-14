using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
   public  interface ICustomerServices
    {
        Customer Create(Customer customer);
        List<Customer> GetAll();
        Customer Update(Customer customer);
        //Customer Delete(int id);
        //List<Customer> Search(CustomerDTO CustomerDTO);
        //Task<List<Customer>> GetAllCustomer();
    }
}
