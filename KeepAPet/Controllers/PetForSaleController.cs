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
    public class PetForSalesController : Controller
    {
        private readonly IPetForSaleServices PetForSalesServices;
        public PetForSalesController(IPetForSaleServices petForSalesServices)
        {
            PetForSalesServices = petForSalesServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(PetForSales), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(PetForSales), StatusCodes.Status400BadRequest)]
        public PetForSales Create([FromBody] PetForSales PetForSales)
        {
            return PetForSalesServices.Create(PetForSales);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<PetForSales>), StatusCodes.Status200OK)]
        public List<PetForSales> GetAll()
        {
            return PetForSalesServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(PetForSales), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(PetForSales), StatusCodes.Status400BadRequest)]
        public PetForSales Update([FromBody] PetForSales petForSales)
        {
            return PetForSalesServices.Update(petForSales);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public PetForSaless Delete(int id)
        //{
        //    return PetForSalesServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("PetForSalesSearch")]
        //[ProducesResponseType(typeof(List<PetForSales>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<PetForSales>), StatusCodes.Status400BadRequest)]
        //public List<PetForSales> Search([FromBody] PetForSalesDTO PetForSalesDTO)
        //{
        //    return PetForSalesServices.Search(PetForSalesDTO);
        //}
        //[HttpGet]
        //[Route("GetAllPetForSales")]
        //[ProducesResponseType(typeof(List<PetForSales>), StatusCodes.Status200OK)]
        //public async Task<List<PetForSales>> GetAllPetForSales()
        //{
        //    return await PetForSalesServices.GetAllPetForSales();
        //}
    }
}
