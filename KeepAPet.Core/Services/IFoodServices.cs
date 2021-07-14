using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
    public interface IFoodServices
    {
        Food Create(Food Food);
        List<Food> GetAll();
        Food Update(Food Food);
        //Food Delete(int id);
        //List<Food> Search(FoodDTO FoodDTO);
        //Task<List<Food>> GetAllFood();
    }
}
