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

namespace KeepAPets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : Controller
    {private readonly IConfiguration _configuration;


        private readonly IWebHostEnvironment _env;

        private readonly IPetServices PetsServices;
        public PetsController(IPetServices petsServices, IConfiguration configuration, IWebHostEnvironment env)
        {
            PetsServices = petsServices;
             _configuration = configuration;
            _env = env;
        }
        

        [HttpPost]
        [ProducesResponseType(typeof(Pets), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Pets), StatusCodes.Status400BadRequest)]
        public Pets Create([FromBody] Pets pets)
        {
            return PetsServices.Create(pets);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Pets>), StatusCodes.Status200OK)]
        public List<Pets> GetAll()
        {
            return PetsServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Pets), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Pets), StatusCodes.Status400BadRequest)]
        public Pets Update([FromBody] Pets pets)
        {
            return PetsServices.Update(pets);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Petss Delete(int id)
        //{
        //    return PetsServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("PetsSearch")]
        //[ProducesResponseType(typeof(List<Pets>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Pets>), StatusCodes.Status400BadRequest)]
        //public List<Pets> Search([FromBody] PetsDTO PetsDTO)
        //{
        //    return PetsServices.Search(PetsDTO);
        //}
        //[HttpGet]
        //[Route("GetAllPets")]
        //[ProducesResponseType(typeof(List<Pets>), StatusCodes.Status200OK)]
        //public async Task<List<Pets>> GetAllPets()
        //{
        //    return await PetsServices.GetAllPets();
        //}
     [Route("SaveFile")]
        [HttpPost]
        public JsonResult SaveFile()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = _env.ContentRootPath + "/Photos/" + filename;
 
                using (var stream = new FileStream(physicalPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }
 
                return new JsonResult(filename);
            }
            catch (Exception)
            {
 
                return new JsonResult("anonymous.png");
            }
        }
        [HttpGet]
        [Route("GetPetsByClinic")]
        public JsonResult GetPetsByClinic(int id)
        {
            string query = @"select * from pets where Pets.Available=1 and ClinicId='" + id + "'";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DBConnectionString");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }
        [HttpPost]
        [Route("Book")]
         [ProducesResponseType(typeof(Pets), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Pets), StatusCodes.Status400BadRequest)]

       
         public BookPet Book([FromBody] BookPet data)
        {
            return PetsServices.Book(data);
        }
      
}}
