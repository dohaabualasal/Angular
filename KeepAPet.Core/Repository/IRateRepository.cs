using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
    public interface IRateRepository
    {
        int Create(Rate Data);
        List<Rate> GetAll();
        int Update(Rate Data);
        //int Delete(int id);
         List<Rate> Search(DoctorRateDTO RateDTO);
        //Task<List<Rate>> GetAllRate();
    }
}
