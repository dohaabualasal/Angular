using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
   public  class PetForSaleServices:IPetForSaleServices
    {
        private readonly IPetForSaleRepository PetForSaleRepository;
        public PetForSaleServices(IPetForSaleRepository petForSaleRepository)
        {
            PetForSaleRepository = petForSaleRepository;
        }
        public PetForSales Create(PetForSales PetForSale)
        {
            PetForSaleRepository.Create(PetForSale);
            return PetForSale;
        }
        public List<PetForSales> GetAll()
        {
            return PetForSaleRepository.GetAll();

        }
        public PetForSales Update(PetForSales PetForSale)
        {
            PetForSaleRepository.Update(PetForSale);
            return PetForSale;
        }
        //public PetForSale Delete(int id)
        //{
        //    PetForSaleRepository.Delete(id);
        //    return new PetForSale();
        //}
        //public List<PetForSale> Search(PetForSaleDTO PetForSaleDTO)
        //{
        //    return PetForSaleRepository.Search(PetForSaleDTO);
        //}
        //public async Task<List<PetForSale>> GetAllPetForSale()
        //{
        //    return await PetForSaleRepository.GetAllPetForSale();
        //}
    }
}
