using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
   public  class RateServices:IRateServices
    {
        private readonly IRateRepository RateRepository;
        public RateServices(IRateRepository rateRepository)
        {
            RateRepository = rateRepository;
        }
        public Rate Create(Rate Rate)
        {
            RateRepository.Create(Rate);
            return Rate;
        }
        public List<Rate> GetAll()
        {
            return RateRepository.GetAll();

        }
        public Rate Update(Rate Rate)
        {
            RateRepository.Update(Rate);
            return Rate;
        }
        //public Rate Delete(int id)
        //{
        //    RateRepository.Delete(id);
        //    return new Rate();
        //}
        public List<Rate> Search(DoctorRateDTO RateDTO)
        {
            return RateRepository.Search(RateDTO);
        }
        //public async Task<List<Rate>> GetAllRate()
        //{
        //    return await RateRepository.GetAllRate();
        //}
    }
}
