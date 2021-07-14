using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
   public  interface IPetForSaleServices
    {
        PetForSales Create(PetForSales petForSale);
        List<PetForSales> GetAll();
        PetForSales Update(PetForSales petForSale);
       //PetForSales Delete(int id);
        //List<PetForSale> Search(PetForSaleDTO PetForSaleDTO);
        //Task<List<PetForSale>> GetAllPetForSale();
    }
}
