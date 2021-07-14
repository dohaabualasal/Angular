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
    public class SalesController : Controller
    {
        private readonly ISalesServices SalesServices;
        public SalesController(ISalesServices salesServices)
        {
            SalesServices = salesServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Sales), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Sales), StatusCodes.Status400BadRequest)]
        public Sales Create([FromBody] Sales sales)
        {
            return SalesServices.Create(sales);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Sales>), StatusCodes.Status200OK)]
        public List<Sales> GetAll()
        {
            return SalesServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Sales), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Sales), StatusCodes.Status400BadRequest)]
        public Sales Update([FromBody] Sales sales)
        {
            return SalesServices.Update(sales);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Saless Delete(int id)
        //{
        //    return SalesServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("SalesSearch")]
        //[ProducesResponseType(typeof(List<Sales>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Sales>), StatusCodes.Status400BadRequest)]
        //public List<Sales> Search([FromBody] SalesDTO SalesDTO)
        //{
        //    return SalesServices.Search(SalesDTO);
        //}
        //[HttpGet]
        //[Route("GetAllSales")]
        //[ProducesResponseType(typeof(List<Sales>), StatusCodes.Status200OK)]
        //public async Task<List<Sales>> GetAllSales()
        //{
        //    return await SalesServices.GetAllSales();
        //}
    }
}
