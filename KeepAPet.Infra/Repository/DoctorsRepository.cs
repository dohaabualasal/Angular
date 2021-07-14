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
   public  class DoctorsRepository:IDoctorsRepository
    {
        private readonly IDBContext DBContext;
        public DoctorsRepository(IDBContext dbContext)
        {
            DBContext = dbContext;
        }
        public int Create(Doctors Data)
        {
            var p = new DynamicParameters();
          //  p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", Data.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", Data.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Phone", Data.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", Data.Password, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@ClinicId",Data.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("AddDoctors", p, commandType: CommandType.StoredProcedure);
            return 1;

        }
        public List<Doctors> GetAll()
        {
            IEnumerable<Doctors> result = DBContext.Connection.Query<Doctors>("GetAllDoctors", commandType: CommandType.StoredProcedure);
            return result.ToList();
            //var result = DBContext.Connection.ExecuteAsync("GetAllDoctors", commandType: CommandType.StoredProcedure);
            //return 1;

        }
        public int Update(Doctors Data)
        {
            var p = new DynamicParameters();
            p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", Data.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", Data.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", Data.Password, dbType: DbType.String, direction: ParameterDirection.Input);
           // p.Add("@schedule", Data.schedule, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Phone", Data.Phone, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@ClinicId", Data.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("EditDoctor", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int id)
        {
           var p = new DynamicParameters();
           p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
           var result = DBContext.Connection.ExecuteAsync("DeleteDoctors", p, commandType: CommandType.StoredProcedure);
           return 1;
        }


        //public List<Doctors> Search(DiseasesDoctorsDTO DoctorsDTO)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@DiseasesName", DoctorsDTO.DiseasesName, dbType: DbType.String, direction: ParameterDirection.Input);;
        //    IEnumerable<Doctors> result = DBContext.Connection.Query<Doctors>("DiseasesDoctors", p, commandType: CommandType.StoredProcedure);
        //    return result.ToList();
        //}
        //public async Task<List<Doctors>> GetAllCourse()
        //{
        //    var p = new DynamicParameters();
        //    var result = await DBContext.Connection.QueryAsync<Doctors, Diseases, Doctors>("GetAll", (Doctors, diseases) =>
        //    {
        //        Doctors. = Doctors.Books ?? new List<Diseases>();
        //        Doctors.Books.Add(diseases);
        //        return Doctors;
        //    }
        //    , splitOn: "BookId"
        //    , param: null
        //    , commandType: CommandType.StoredProcedure);

        //    var finalResult = result.AsList<Doctors>().GroupBy(p => p.Id).Select(g =>
        //    {
        //        Doctors Doctors = g.First();
        //        Doctors.Books = g.Where(g => g.Books.Any() && g.Books.Count > 0).Select(p => p.Books.Single()).
        //        GroupBy(book => book.BookId).Select(book => new Book
        //        {
        //            BookId = book.First().BookId,
        //            BookName = book.First().BookName
        //        }).ToList();
        //        return Doctors;
        //    }).ToList();
        //    return finalResult;
        //}

    }
}

