using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
   public  interface IFoodRepository
    {
        int Create(Food Data);
        List<Food> GetAll();
        int Update(Food Data);
        //int Delete(int id);
        // List<Food> Search(FoodDTO FoodDTO);
        //Task<List<Food>> GetAllFood();
    }
}
