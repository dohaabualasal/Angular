
using Dapper;
using KeepAPet.Core.Common;
using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace KeepAPet.Infra.Repository
{
    public class PetRepository: IPetRepository
    {
        private readonly IDBContext DBContext;
        public PetRepository(IDBContext dbContext)
        {
            DBContext = dbContext;
        }
        public int Create(Pets Data)
        {
            var p = new DynamicParameters();
            // p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            
            p.Add("@Name", Data.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Age", Data.Age, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Image", Data.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Biography", Data.Biography, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Gender", Data.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Price", Data.Price, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@ClinicId", Data.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
             p.Add("@Category", Data.Category, dbType: DbType.String, direction: ParameterDirection.Input);
            // p.Add("@DoctorId", Data.DoctorId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DBContext.Connection.ExecuteAsync("AddPets", p, commandType: CommandType.StoredProcedure);
            return 1;

        }
        public List<Pets> GetAll()
        {
            IEnumerable<Pets> result = DBContext.Connection.Query<Pets>("GetAllPet", commandType: CommandType.StoredProcedure);
            return result.ToList();
            //var result = DBContext.Connection.ExecuteAsync("GetAllEmployee", commandType: CommandType.StoredProcedure);
            //return 1;

        }
        public int Update(Pets Data)
        {
            var p = new DynamicParameters();
            p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
          p.Add(" @Price", Data.Price, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@Name", Data.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Age", Data.Age, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Image", Data.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Biography", Data.Biography, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Gender", Data.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
           
            p.Add("@ClinicId", Data.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
             p.Add("@Category", Data.Category, dbType: DbType.String, direction: ParameterDirection.Input);
             var result = DBContext.Connection.ExecuteAsync("EditPet", p, commandType: CommandType.StoredProcedure);
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
        //public List<Employee> Search(EmployeeDTO EmployeeDTO)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@EmployeeName", EmployeeDTO.EmployeeName, dbType: DbType.String, direction: ParameterDirection.Input);
        //    p.Add("@DateFrom", EmployeeDTO.DateFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
        //    p.Add("@DateTo", EmployeeDTO.DateTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);
        //    p.Add("@CategoryName", EmployeeDTO.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
        //    IEnumerable<Employee> result = DBContext.Connection.Query<Employee>("SearchEmployee", p, commandType: CommandType.StoredProcedure);
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

      public int Book(BookPet Data)
        {
            var p = new DynamicParameters();
            p.Add("@PetId", Data.PetId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@PhoneNumber", Data.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DBContext.Connection.ExecuteAsync("Book", p, commandType: CommandType.StoredProcedure);
            return 1;

        }
      
    }
}
