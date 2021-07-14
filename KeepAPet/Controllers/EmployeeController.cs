using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using KeepAPets.Core.Services;
using Microsoft.AspNetCore.Authorization;
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
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices EmployeeServices;
        public EmployeeController(IEmployeeServices employeeServices)
        {
            EmployeeServices = employeeServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Employees), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Employees), StatusCodes.Status400BadRequest)]
        public Employees Create([FromBody] Employees employee)
        {
            return EmployeeServices.Create(employee);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Employees>), StatusCodes.Status200OK)]
        public List<Employees> GetAll()
        {
            return EmployeeServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Employees), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Employees), StatusCodes.Status400BadRequest)]
        public Employees Update([FromBody] Employees employee)
        {
            return EmployeeServices.Update(employee);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Employees Delete(int id)
        //{
        //    return EmployeeServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("EmployeeSearch")]
        //[ProducesResponseType(typeof(List<Employees>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Employees>), StatusCodes.Status400BadRequest)]
        //public List<Employees> Search([FromBody] EmployeeDTO employeeDTO)
        //{
        //    return EmployeeServices.Search(employeeDTO);
        //}
        //[HttpGet]
        //[Route("GetAllEmployee")]
        //[ProducesResponseType(typeof(List<Employees>), StatusCodes.Status200OK)]
        //public async Task<List<Employees>> GetAllEmployee()
        //{
        //    return await EmployeeServices.GetAllEmployee();
        //}
    }
}
