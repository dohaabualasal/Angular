using KeepAPets.Core.Entity;
using KeepAPets.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepAPets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : Controller
    {
        private readonly IFoodServices FoodServices;
        public FoodController(IFoodServices foodServices)
        {
            FoodServices = foodServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Food), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Food), StatusCodes.Status400BadRequest)]
        public Food Create([FromBody] Food food)
        {
            return FoodServices.Create(food);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Food>), StatusCodes.Status200OK)]
        public List<Food> GetAll()
        {
            return FoodServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Food), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Food), StatusCodes.Status400BadRequest)]
        public Food Update([FromBody] Food food)
        {
            return FoodServices.Update(food);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Foods Delete(int id)
        //{
        //    return FoodServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("FoodSearch")]
        //[ProducesResponseType(typeof(List<Food>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Food>), StatusCodes.Status400BadRequest)]
        //public List<Food> Search([FromBody] FoodDTO FoodDTO)
        //{
        //    return FoodServices.Search(FoodDTO);
        //}
        //[HttpGet]
        //[Route("GetAllFood")]
        //[ProducesResponseType(typeof(List<Food>), StatusCodes.Status200OK)]
        //public async Task<List<Food>> GetAllFood()
        //{
        //    return await FoodServices.GetAllFood();
        //}
    }
}
