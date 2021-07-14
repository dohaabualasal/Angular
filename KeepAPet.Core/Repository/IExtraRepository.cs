using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
   public  interface IExtraRepository
    {
        int Create(Extra Data);
        List<Extra> GetAll();
        int Update(Extra Data);
        //int Delete(int id);
        // List<Extra> Search(ExtraDTO ExtraDTO);
        //Task<List<Extra>> GetAllExtra();
    }
}
