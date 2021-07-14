using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
    public class FoodServices:IFoodServices
    {
        private readonly IFoodRepository FoodRepository;
        public FoodServices(IFoodRepository foodRepository)
        {
            FoodRepository = foodRepository;
        }
        public Food Create(Food Food)
        {
            FoodRepository.Create(Food);
            return Food;
        }
        public List<Food> GetAll()
        {
            return FoodRepository.GetAll();

        }
        public Food Update(Food Food)
        {
            FoodRepository.Update(Food);
            return Food;
        }
        //public Food Delete(int id)
        //{
        //    FoodRepository.Delete(id);
        //    return new Food();
        //}
        //public List<Food> Search(FoodDTO FoodDTO)
        //{
        //    return FoodRepository.Search(FoodDTO);
        //}
        //public async Task<List<Food>> GetAllFood()
        //{
        //    return await FoodRepository.GetAllFood();
        //}
    }
}
