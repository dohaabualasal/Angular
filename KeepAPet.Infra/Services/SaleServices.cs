using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
    public class SaleServices:ISalesServices
    {
        private readonly ISalesRepository SalesRepository;
        public SaleServices(ISalesRepository salesRepository)
        {
            SalesRepository = salesRepository;
        }
        public Sales Create(Sales Sales)
        {
            SalesRepository.Create(Sales);
            return Sales;
        }
        public List<Sales> GetAll()
        {
            return SalesRepository.GetAll();

        }
        public Sales Update(Sales Sales)
        {
            SalesRepository.Update(Sales);
            return Sales;
        }
        //public Sales Delete(int id)
        //{
        //    SalesRepository.Delete(id);
        //    return new Sales();
        //}
        //public List<Sales> Search(SalesDTO SalesDTO)
        //{
        //    return SalesRepository.Search(SalesDTO);
        //}
        //public async Task<List<Sales>> GetAllSales()
        //{
        //    return await SalesRepository.GetAllSales();
        //}+
    }
}
