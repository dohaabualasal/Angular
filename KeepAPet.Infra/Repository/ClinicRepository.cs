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

namespace KeepAPets.Infra.Repository
{
   public class ClinicRepository:IClinicRepository
    {
        private readonly IDBContext DBContext;
        public ClinicRepository(IDBContext dbContext)
        {
            DBContext = dbContext;
        }
        public int Create(Clinic Data)
        {
            var p = new DynamicParameters();
            //p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@name", Data.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@phone", Data.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@email", Data.Email, dbType: DbType.String, direction: ParameterDirection.Input);
 //           p.Add("@adminId", Data.adminId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Image", Data.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@partmentNum", Data.PartmentNum, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@city", Data.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@country", Data.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@street", Data.Street, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@building", Data.Building, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DBContext.Connection.ExecuteAsync("AddClinic", p, commandType: CommandType.StoredProcedure);
            return 1;

        }
        public List<Clinic> GetAll()
        {
            IEnumerable<Clinic> result = DBContext.Connection.Query<Clinic>("GetAll", commandType: CommandType.StoredProcedure);
            return result.ToList();
            //var result = DBContext.Connection.ExecuteAsync("GetAllEmployee", commandType: CommandType.StoredProcedure);
            //return 1;

        }
        public int Update(Clinic Data)
        {
            var p = new DynamicParameters();
            p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", Data.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Phone", Data.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", Data.Email, dbType: DbType.String, direction: ParameterDirection.Input);
           // p.Add("@adminId", Data.adminId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Image", Data.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PartmentNum", Data.PartmentNum, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", Data.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Country", Data.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Street", Data.Street, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Building", Data.Building, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DBContext.Connection.ExecuteAsync("EditClinic", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("DeleteClinic", p, commandType: CommandType.StoredProcedure);
            return 1;
        }


        //public List<Clinic> Search(LocationClinicDTO clinicDTO)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@DoctorName", clinicDTO.DoctorName, dbType: DbType.String, direction: ParameterDirection.Input);
        //    //p.Add("@DateFrom", clinicDTO., dbType: DbType.DateTime, direction: ParameterDirection.Input);
        //    IEnumerable<Clinic> result = DBContext.Connection.Query<Clinic>("LocationClinic", p, commandType: CommandType.StoredProcedure);
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
      public int Scedual(Scehdual Data)
        {
            var p = new DynamicParameters();
            p.Add("@DoctorId", Data.DoctorId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", Data.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ScehdualDate", Data.ScehdualDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            
            p.Add("@Email", Data.DoctorId, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Phone", Data.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@TypeOfCounseling", Data.TypeOfCounseling, dbType: DbType.String, direction: ParameterDirection.Input);
            

            var result = DBContext.Connection.ExecuteAsync("ScehdualDate", p, commandType: CommandType.StoredProcedure);
            return 1;
        }

 
    }
}
