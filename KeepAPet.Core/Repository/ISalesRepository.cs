using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
    public interface ISalesRepository
    {
        int Create(Sales Data);
        List<Sales> GetAll();
        int Update(Sales Data);
        //int Delete(int id);
        // List<Sales> Search(SalesDTO SalesDTO);
        //Task<List<Sales>> GetAllSales();
    }
}
