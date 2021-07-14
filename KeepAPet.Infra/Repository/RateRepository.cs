using Dapper;
using KeepAPet.Core.Common;
using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPet.Infra.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace KeepAPets.Infra.Repository
{
   public class RateRepository:IRateRepository
    {
        private readonly IDBContext DBContext;
        public RateRepository(IDBContext dbContext)
        {
            DBContext = dbContext;
        }

        

        public int Create(Rate Data)
        {
            var p = new DynamicParameters();
            p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@RateNum", Data.RateNum, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DBContext.Connection.ExecuteAsync("AddRate", p, commandType: CommandType.StoredProcedure);
            return 1;

        }
        public List<Rate> GetAll()
        {
            IEnumerable<Rate> result = DBContext.Connection.Query<Rate>("GetAllRate", commandType: CommandType.StoredProcedure);
            return result.ToList();
            //var result = DBContext.Connection.ExecuteAsync("GetAllEmployee", commandType: CommandType.StoredProcedure);
            //return 1;

        }
        public int Update(Rate Data)
        {
            var p = new DynamicParameters();
            p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@RateNum", Data.RateNum, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("EditRate", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        //public int Delete(int id)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
        //    var result = DBContext.Connection.ExecuteAsync("DeleteEmployee", p, commandType: CommandType.StoredProcedure);
        //    return 1;
        //}
    

        public List<Rate> Search(DoctorRateDTO rateDTO)
        {
            var p = new DynamicParameters();
            p.Add("@DoctorName", rateDTO.DoctorName, dbType: DbType.String, direction: ParameterDirection.Input);
           
            IEnumerable<Rate> result = DBContext.Connection.Query<Rate>("DoctorRate", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
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
