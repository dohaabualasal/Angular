﻿using Dapper;
using KeepAPet.Core.Common;
using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace KeepAPets.Infra.Repository
{
    public class PetForSaleRepository:IPetForSaleRepository
    {
        private readonly IDBContext DBContext;
        public PetForSaleRepository(IDBContext dbContext)
        {
            DBContext = dbContext;
        }
        public int Create(PetForSales Data)
        {
            var p = new DynamicParameters();
            p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Price", Data.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@FullName", Data.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Age", Data.Age, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Characteristic", Data.Characteristic, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Biography", Data.Biography, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Gender", Data.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@AdminId", Data.AdminId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CategoryId", Data.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            var result = DBContext.Connection.ExecuteAsync("AddPetForSale", p, commandType: CommandType.StoredProcedure);
            return 1;

        }
        public List<PetForSales> GetAll()
        {
            IEnumerable<PetForSales> result = DBContext.Connection.Query<PetForSales>("GetAllPetForSale", commandType: CommandType.StoredProcedure);
            return result.ToList();
            //var result = DBContext.Connection.ExecuteAsync("GetAllEmployee", commandType: CommandType.StoredProcedure);
            //return 1;

        }
        public int Update(PetForSales Data)
        {
            var p = new DynamicParameters();
            p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Price", Data.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@FullName", Data.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Age", Data.Age, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Characteristic", Data.Characteristic, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Biography", Data.Biography, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Gender", Data.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@AdminId", Data.AdminId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CategoryId", Data.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("EditPetForSale", p, commandType: CommandType.StoredProcedure);
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
    }
}
