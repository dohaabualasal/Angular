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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices CategoryServices;
        public CategoryController(ICategoryServices categoryServices)
        {
            CategoryServices = categoryServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Category), StatusCodes.Status400BadRequest)]
        public Category Create([FromBody] Category category)
        {
            return CategoryServices.Create(category);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public List<Category> GetAll()
        {
            return CategoryServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Category), StatusCodes.Status400BadRequest)]
        public Category Update([FromBody] Category category)
        {
            return CategoryServices.Update(category);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Categorys Delete(int id)
        //{
        //    return CategoryServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("CategorySearch")]
        //[ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Category>), StatusCodes.Status400BadRequest)]
        //public List<Category> Search([FromBody] CategoryDTO CategoryDTO)
        //{
        //    return CategoryServices.Search(CategoryDTO);
        //}
        //[HttpGet]
        //[Route("GetAllCategory")]
        //[ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        //public async Task<List<Category>> GetAllCategory()
        //{
        //    return await CategoryServices.GetAllCategory();
        //}
    }
}
