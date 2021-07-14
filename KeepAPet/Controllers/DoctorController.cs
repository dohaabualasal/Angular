using Dapper;
using KeepAPet.Core.Common;
using KeepAPets.Core.Entity;
using KeepAPets.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeepAPets.Core.Repository;
using System.Data;
using KeepAPet.Infra.Common;
using Microsoft.AspNetCore.Hosting;
using AutoMapper.Configuration;
using System.Data.SqlClient;

namespace KeepAPets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        /*private readonly IConfiguration _configuration;


        private readonly IWebHostEnvironment _env;



        private readonly IDoctorsServices DoctorsServices;
        public DoctorController( IDoctorsServices doctorsServices,IConfiguration configuration, IWebHostEnvironment env)
        {
            DoctorsServices = doctorsServices;
            _configuration = configuration;
            _env = env;

        }
        [HttpPost]
        [ProducesResponseType(typeof(Doctors), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Doctors), StatusCodes.Status400BadRequest)]
        public Doctors Create([FromBody] Doctors Doctors)
        {
            return DoctorsServices.Create(Doctors);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Doctors>), StatusCodes.Status200OK)]
        public List<Doctors> GetAll()
        {
            return DoctorsServices.GetAll();
        }
        [HttpPut]
       
        public Doctors Update([FromBody] Doctors Doctors)
        {
            return DoctorsServices.Update(Doctors);
        }
       
        [HttpDelete("{id}")]
        public Doctors Delete(int id)
        {
           return DoctorsServices.Delete(id);
        }
       */

}
}
