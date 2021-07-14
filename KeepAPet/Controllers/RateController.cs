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
    public class RateController : Controller
    {
        private readonly IRateServices RateServices;
        public RateController(IRateServices rateServices)
        {
            RateServices = rateServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Rate), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Rate), StatusCodes.Status400BadRequest)]
        public Rate Create([FromBody] Rate rate)
        {
            return RateServices.Create(rate);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Rate>), StatusCodes.Status200OK)]
        public List<Rate> GetAll()
        {
            return RateServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Rate), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Rate), StatusCodes.Status400BadRequest)]
        public Rate Update([FromBody] Rate rate)
        {
            return RateServices.Update(rate);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Rates Delete(int id)
        //{
        //    return RateServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("RateSearch")]
        //[ProducesResponseType(typeof(List<Rate>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Rate>), StatusCodes.Status400BadRequest)]
        //public List<Rate> Search([FromBody] RateDTO RateDTO)
        //{
        //    return RateServices.Search(RateDTO);
        //}
        //[HttpGet]
        //[Route("GetAllRate")]
        //[ProducesResponseType(typeof(List<Rate>), StatusCodes.Status200OK)]
        //public async Task<List<Rate>> GetAllRate()
        //{
        //    return await RateServices.GetAllRate();
        //}
    }
}
