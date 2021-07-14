using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
   public interface IRateServices
    {
        Rate Create(Rate rate);
        List<Rate> GetAll();
        Rate Update(Rate rate);
        //Rate Delete(int id);
        List<Rate> Search(DoctorRateDTO RateDTO);
        //Task<List<Rate>> GetAllRate();
    }
}
