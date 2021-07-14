using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
    public interface ICustomerRepository
    {
        int Create(Customer Data);
        List<Customer> GetAll();
        int Update(Customer Data);
        //int Delete(int id);
        // List<Customer> Search(CustomerDTO CustomerDTO);
        //Task<List<Customer>> GetAllCustomer();
    }
}
