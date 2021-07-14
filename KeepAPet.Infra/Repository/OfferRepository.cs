using Dapper;
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
    public class OfferRepository: IOfferRepository
    { private readonly IDBContext DBContext;
        public OfferRepository(IDBContext dbContext)
        {
            DBContext = dbContext;
        }
        public int Create(Offer Data)
        {
            var p = new DynamicParameters();
           // p.Add("@Id", Data.OfferId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@OldPrice", Data.OldPrice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@NewPrice", Data.NewPrice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@Name", Data.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Image", Data.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DateForm", Data.DateFrom, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@DateTo", Data.DateTo, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@CategoryType", Data.CategoryType, dbType: DbType.String, direction: ParameterDirection.Input);
           

            var result = DBContext.Connection.ExecuteAsync("AddOffer", p, commandType: CommandType.StoredProcedure);
            return 1;

        }
        public List<Offer> GetAll()
        {
            IEnumerable<Offer> result = DBContext.Connection.Query<Offer>("GetAllOffer", commandType: CommandType.StoredProcedure);
            return result.ToList();
            

        }
        public int Update(Offer Data)
        {
            var p = new DynamicParameters();
            p.Add("@OfferId", Data.OfferId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@OldPrice", Data.OldPrice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@NewPrice", Data.NewPrice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@Name", Data.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Image", Data.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DateForm", Data.DateFrom, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@DateTo", Data.DateTo, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@CategoryType", Data.CategoryType, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DBContext.Connection.ExecuteAsync("EditOffer", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@OfferId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("DeleteOffer", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
    }}