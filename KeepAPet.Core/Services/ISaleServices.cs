using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
   public  interface ISalesServices
    {
        Sales Create(Sales sales);
        List<Sales> GetAll();
        Sales Update(Sales sales);
        //Sales Delete(int id);
        //List<Sales> Search(SalesDTO SalesDTO);
        //Task<List<Sales>> GetAllSales();
    }
}
