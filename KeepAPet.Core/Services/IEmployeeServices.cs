using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KeepAPets.Core.Services
{
    public interface IEmployeeServices
    {
        Employees Create(Employees employee);
        List<Employees> GetAll();
        Employees Update(Employees employee);
      // Employees Delete(int id);
        //List<Employees>Search(EmployeeDTO employeeDTO);
      //  Task<List<Employees>> GetAllEmployee();
    }
}
