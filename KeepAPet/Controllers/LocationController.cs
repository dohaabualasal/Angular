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
    public class LocationController : Controller
    {
        private readonly ILocationServices LocationServices;
        public LocationController(ILocationServices locationServices)
        {
            LocationServices = locationServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Location), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Location), StatusCodes.Status400BadRequest)]
        public Location Create([FromBody] Location location)
        {
            return LocationServices.Create(location);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Location>), StatusCodes.Status200OK)]
        public List<Location> GetAll()
        {
            return LocationServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Location), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Location), StatusCodes.Status400BadRequest)]
        public Location Update([FromBody] Location location)
        {
            return LocationServices.Update(location);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Locations Delete(int id)
        //{
        //    return LocationServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("LocationSearch")]
        //[ProducesResponseType(typeof(List<Location>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Location>), StatusCodes.Status400BadRequest)]
        //public List<Location> Search([FromBody] LocationDTO LocationDTO)
        //{
        //    return LocationServices.Search(LocationDTO);
        //}
        //[HttpGet]
        //[Route("GetAllLocation")]
        //[ProducesResponseType(typeof(List<Location>), StatusCodes.Status200OK)]
        //public async Task<List<Location>> GetAllLocation()
        //{
        //    return await LocationServices.GetAllLocation();
        //}
    }
}
