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
    public class DiseasesController : ControllerBase
    {
        private readonly IDiseasesServices DiseasesServices;
        public DiseasesController(IDiseasesServices diseasesServices)
        {
            DiseasesServices = diseasesServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Diseases), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Diseases), StatusCodes.Status400BadRequest)]
        public Diseases Create([FromBody] Diseases diseases)
        {
            return DiseasesServices.Create(diseases);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Diseases>), StatusCodes.Status200OK)]
        public List<Diseases> GetAll()
        {
            return DiseasesServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Diseases), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Diseases), StatusCodes.Status400BadRequest)]
        public Diseases Update([FromBody] Diseases diseases)
        {
            return DiseasesServices.Update(diseases);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Diseasess Delete(int id)
        //{
        //    return DiseasesServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("DiseasesSearch")]
        //[ProducesResponseType(typeof(List<Diseases>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Diseases>), StatusCodes.Status400BadRequest)]
        //public List<Diseases> Search([FromBody] DiseasesDTO DiseasesDTO)
        //{
        //    return DiseasesServices.Search(DiseasesDTO);
        //}
        //[HttpGet]
        //[Route("GetAllDiseases")]
        //[ProducesResponseType(typeof(List<Diseases>), StatusCodes.Status200OK)]
        //public async Task<List<Diseases>> GetAllDiseases()
        //{
        //    return await DiseasesServices.GetAllDiseases();
        //}
    }
}
