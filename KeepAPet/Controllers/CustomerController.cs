using KeepAPets.Core.Entity;
using KeepAPets.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepAPets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerServices CustomerServices;
        public CustomerController(ICustomerServices customerServices)
        {
            CustomerServices = customerServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status400BadRequest)]
        public Customer Create([FromBody] Customer customer)
        {
            return CustomerServices.Create(customer);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        public List<Customer> GetAll()
        {
            return CustomerServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status400BadRequest)]
        public Customer Update([FromBody] Customer customer)
        {
            return CustomerServices.Update(customer);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Customers Delete(int id)
        //{
        //    return CustomerServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("CustomerSearch")]
        //[ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Customer>), StatusCodes.Status400BadRequest)]
        //public List<Customer> Search([FromBody] CustomerDTO CustomerDTO)
        //{
        //    return CustomerServices.Search(CustomerDTO);
        //}
        //[HttpGet]
        //[Route("GetAllCustomer")]
        //[ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        //public async Task<List<Customer>> GetAllCustomer()
        //{
        //    return await CustomerServices.GetAllCustomer();
        //}
    }
}
