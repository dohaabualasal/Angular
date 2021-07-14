using KeepAPets.Core.Entity;
using KeepAPets.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using KeepAPet.Core.Common;
using KeepAPet.Infra.Common;
using Dapper;
using System.IO;
using Microsoft.AspNetCore.Hosting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KeepAPets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        // GET: api/<DoctorsController>
        private readonly IConfiguration _configuration;


        private readonly IWebHostEnvironment _env;

        public DoctorsController(IDoctorsServices doctorsServices, IConfiguration configuration, IWebHostEnvironment env)
        {
            DoctorsServices = doctorsServices;
            _configuration = configuration;
            _env = env;

        }
         [HttpPost]
        public Doctors Post([FromBody] Doctors Doctors)
        {
            return DoctorsServices.Create(Doctors);
        }

        private readonly IDoctorsServices DoctorsServices;
        [HttpGet]
        [ProducesResponseType(typeof(List<Doctors>), StatusCodes.Status200OK)]
        public List<Doctors> GetAll()
        {
            return DoctorsServices.GetAll();
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DoctorsController>
       

        // PUT api/<DoctorsController>/5
        [HttpPut]

        public Doctors Update([FromBody] Doctors Doctors)
        {
            return DoctorsServices.Update(Doctors);
        }

        // DELETE api/<DoctorsController>/5

        [HttpDelete("{id}")]
        public Doctors Delete(int id)
        {
            return DoctorsServices.Delete(id);
        }


    }
}
