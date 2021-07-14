using Dapper;
using KeepAPet.Core.Common;
using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepAPets.Infra.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly IDBContext DBContext;
        public EmployeeRepository(IDBContext dbContext)
        {
            DBContext = dbContext;
        }
        public int Create(Employees Data)
        {
            var p = new DynamicParameters();
            p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", Data.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", Data.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", Data.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@RateId", Data.RateId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@JobTitleId", Data.JobTitleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@LocationId", Data.LocationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("AddEmployee", p, commandType: CommandType.StoredProcedure);
            return 1;

        }
        public List<Employees> GetAll()
        {
            IEnumerable<Employees> result = DBContext.Connection.Query<Employees>("GetAllEmployee", commandType: CommandType.StoredProcedure);
            return result.ToList();
            //var result = DBContext.Connection.ExecuteAsync("GetAllEmployee", commandType: CommandType.StoredProcedure);
            //return 1;

        }
        public int Update(Employees Data)
        {
            var p = new DynamicParameters();
            p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", Data.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", Data.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", Data.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@RateId", Data.RateId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@JobTitleId", Data.JobTitleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@LocationId", Data.LocationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("EditEmployee", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        //public int Delete(int id)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
        //    var result = DBContext.Connection.ExecuteAsync("DeleteEmployee", p, commandType: CommandType.StoredProcedure);
        //    return 1;
        //}

        //public System.Threading.Tasks.Task<List<Employee>> GetAllEmployee()
        //{
        //    throw new NotImplementedException();
        //}
        //public List<Employees> Search(EmployeeDTO employeeDTO)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@EmployeeName", EmployeeDTO., dbType: DbType.String, direction: ParameterDirection.Input);
        //    p.Add("@DateFrom", EmployeeDTO.DateFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
        //    p.Add("@DateTo", EmployeeDTO.DateTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);
        //    p.Add("@CategoryName", EmployeeDTO.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
        //    IEnumerable<Employees> result = DBContext.Connection.Query<Employees>("SearchEmployee", p, commandType: CommandType.StoredProcedure);
        //    return result.ToList();
        //}
        //public async Task<List<Employee>> GetAllEmployee()
        //{
        //    var p = new DynamicParameters();
        //    var result = await DBContext.Connection.QueryAsync<Employee, Book, Employee>("GetAll", (employee, book) =>
        //    {
        //        Employee.Books = Employee.Books ?? new List<Book>();
        //        Employee.Books.Add(book);
        //        return Employee;
        //    }
        //    , splitOn: "BookId"
        //    , param: null
        //    , commandType: CommandType.StoredProcedure);

        //    var finalResult = result.AsList<Employee>().GroupBy(p => p.EmployeeId).Select(g =>
        //    {
        //        Employee employee = g.First();
        //        Employee.Books = g.Where(g => g.Books.Any() && g.Books.Count > 0).Select(p => p.Books.Single()).
        //        GroupBy(book => book.BookId).Select(book => new Book
        //        {
        //            BookId = book.First().BookId,
        //            BookName = book.First().BookName
        //        }).ToList();
        //        return Employee;
        //    }).ToList();
        //    return finalResult;
        //}
    }
}
