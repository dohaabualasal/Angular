using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
    public class CustomerServices:ICustomerServices
    {
        private readonly ICustomerRepository CustomerRepository;
        public CustomerServices(ICustomerRepository customerRepository)
        {
            CustomerRepository = customerRepository;
        }
        public Customer Create(Customer Customer)
        {
            CustomerRepository.Create(Customer);
            return Customer;
        }
        public List<Customer> GetAll()
        {
            return CustomerRepository.GetAll();

        }
        public Customer Update(Customer Customer)
        {
            CustomerRepository.Update(Customer);
            return Customer;
        }
        //public Customer Delete(int id)
        //{
        //    CustomerRepository.Delete(id);
        //    return new Customer();
        //}
        //public List<Customer> Search(CustomerDTO CustomerDTO)
        //{
        //    return CustomerRepository.Search(CustomerDTO);
        //}
        //public async Task<List<Customer>> GetAllCustomer()
        //{
        //    return await CustomerRepository.GetAllCustomer();
        //}
    }
}
