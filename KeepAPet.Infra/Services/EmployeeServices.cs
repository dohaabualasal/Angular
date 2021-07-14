using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KeepAPets.Infra.Services
{
    public class EmployeeServices: IEmployeeServices
    {
        private readonly IEmployeeRepository EmployeeRepository;
        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository;
        }
        public Employees Create(Employees employee)
        {
            EmployeeRepository.Create(employee);
            return employee;
        }
        public List<Employees> GetAll()
        {
            return EmployeeRepository.GetAll();

        }
        public Employees Update(Employees employee)
        {
            EmployeeRepository.Update(employee);
            return employee;
        }
        //public Employees Delete(int id)
        //{
        //    EmployeeRepository.Delete(id);
        //    return new Employees();
        //}
        //public List<Employees> Search(EmployeeDTO employeeDTO)
        //{
        //    return EmployeeRepository.Search(employeeDTO);
        //}

        //public async Task<List<Employees>> GetAllEmployee()
        //{
        //    return await EmployeeRepository.GetAllEmployee();
        //}
    }
}
