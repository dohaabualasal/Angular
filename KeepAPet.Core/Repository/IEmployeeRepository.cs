
using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KeepAPets.Core.Repository
{
    public interface IEmployeeRepository
    {
        int Create(Employees Data);
        List<Employees> GetAll();
        int Update(Employees Data);
        //List<Employees> Search(EmployeeDTO employeeDTO);
        //Task<List<Employees>> GetAllEmployee();
        //int Delete(int id);
       
    }
}
