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
   /* [Route("api/[controller]")]
    [ApiController]
    public class BillController : Controller
    {
        private readonly IBillServices BillServices;
        public BillController(IBillServices billServices)
        {
            BillServices = billServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Bill), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Bill), StatusCodes.Status400BadRequest)]
        public Bill Create([FromBody] Bill bill)
        {
            return BillServices.Create(bill);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Bill>), StatusCodes.Status200OK)]
        public List<Bill> GetAll()
        {
            return BillServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Bill), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Bill), StatusCodes.Status400BadRequest)]
        public Bill Update([FromBody] Bill bill)
        {
            return BillServices.Update(bill);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Bills Delete(int id)
        //{
        //    return BillServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("BillSearch")]
        //[ProducesResponseType(typeof(List<Bill>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Bill>), StatusCodes.Status400BadRequest)]
        //public List<Bill> Search([FromBody] BillDTO BillDTO)
        //{
        //    return BillServices.Search(BillDTO);
        //}
        //[HttpGet]
        //[Route("GetAllBill")]
        //[ProducesResponseType(typeof(List<Bill>), StatusCodes.Status200OK)]
        //public async Task<List<Bill>> GetAllBill()
        //{
        //    return await BillServices.GetAllBill();
        //}
    }*/
}
