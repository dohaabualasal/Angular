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
    public class ExtraController : ControllerBase
    {
        private readonly IExtraServices ExtraServices;
        public ExtraController(IExtraServices extraServices)
        {
            ExtraServices = extraServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Extra), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Extra), StatusCodes.Status400BadRequest)]
        public Extra Create([FromBody] Extra extra)
        {
            return ExtraServices.Create(extra);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Extra>), StatusCodes.Status200OK)]
        public List<Extra> GetAll()
        {
            return ExtraServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Extra), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Extra), StatusCodes.Status400BadRequest)]
        public Extra Update([FromBody] Extra extra)
        {
            return ExtraServices.Update(extra);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Extras Delete(int id)
        //{
        //    return ExtraServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("ExtraSearch")]
        //[ProducesResponseType(typeof(List<Extra>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Extra>), StatusCodes.Status400BadRequest)]
        //public List<Extra> Search([FromBody] ExtraDTO ExtraDTO)
        //{
        //    return ExtraServices.Search(ExtraDTO);
        //}
        //[HttpGet]
        //[Route("GetAllExtra")]
        //[ProducesResponseType(typeof(List<Extra>), StatusCodes.Status200OK)]
        //public async Task<List<Extra>> GetAllExtra()
        //{
        //    return await ExtraServices.GetAllExtra();
        //}
    }
}
