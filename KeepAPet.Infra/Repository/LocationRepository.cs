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
    public class LocationRepository: ILocationRepository
    {
        private readonly IDBContext DBContext;
        public LocationRepository(IDBContext dbContext)
        {
            DBContext = dbContext;
        }
        public int Create(Location Data)
        {
            var p = new DynamicParameters();
            p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@PartmentNum", Data.PartmentNum, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@City", Data.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Country", Data.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Street", Data.Street, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Building", Data.Building, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DBContext.Connection.ExecuteAsync("AddLocation", p, commandType: CommandType.StoredProcedure);
            return 1;

        }
        public List<Location> GetAll()
        {
            IEnumerable<Location> result = DBContext.Connection.Query<Location>("GetAllLocation", commandType: CommandType.StoredProcedure);
            return result.ToList();
            //var result = DBContext.Connection.ExecuteAsync("GetAllLocation", commandType: CommandType.StoredProcedure);
            //return 1;

        }
        public int Update(Location Data)
        {
            var p = new DynamicParameters();
            p.Add("@Id", Data.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@PartmentNum", Data.PartmentNum, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@City", Data.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Country", Data.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Street", Data.Street, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Building", Data.Building, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("EditLocation", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        //public int Delete(int id)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
        //    var result = DBContext.Connection.ExecuteAsync("DeleteLocation", p, commandType: CommandType.StoredProcedure);
        //    return 1;
        //}

        
        public List<Location> Search(ClinicLocationDTO locationDTO)
        {
            var p = new DynamicParameters();
            p.Add("@ClinicName", locationDTO.ClinicName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Country", locationDTO.Country, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            IEnumerable<Location> result = DBContext.Connection.Query<Location>("ClinicLocation", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        //public async Task<List<Location>> GetAllLocation()
        //{
        //    var p = new DynamicParameters();
        //    var result = await DBContext.Connection.QueryAsync<Location, Book, Location>("GetAll", (Location, book) =>
        //    {
        //        Location.Books = Location.Books ?? new List<Book>();
        //        Location.Books.Add(book);
        //        return Location;
        //    }
        //    , splitOn: "BookId"
        //    , param: null
        //    , commandType: CommandType.StoredProcedure);

        //    var finalResult = result.AsList<Location>().GroupBy(p => p.LocationId).Select(g =>
        //    {
        //        Location Location = g.First();
        //        Location.Books = g.Where(g => g.Books.Any() && g.Books.Count > 0).Select(p => p.Books.Single()).
        //        GroupBy(book => book.BookId).Select(book => new Book
        //        {
        //            BookId = book.First().BookId,
        //            BookName = book.First().BookName
        //        }).ToList();
        //        return Location;
        //    }).ToList();
        //    return finalResult;
        //}
    }
}
