using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
    public interface IPetForSaleRepository
    {
        int Create(PetForSales Data);
        List<PetForSales> GetAll();
        int Update(PetForSales Data);
        //int Delete(int id);
        // List<PetForSale> Search(PetForSaleDTO PetForSaleDTO);
        //Task<List<PetForSale>> GetAllPetForSale();
    }
}
