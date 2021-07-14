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
    public class OfferController : Controller
    { 
         private readonly IConfiguration _configuration;


        private readonly IWebHostEnvironment _env;


        private readonly IOfferServices OfferServices;
        public OfferController(IOfferServices offerServices , IConfiguration configuration, IWebHostEnvironment env)
        {
            OfferServices = offerServices;
             _configuration = configuration;
            _env = env;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Offer), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Offer), StatusCodes.Status400BadRequest)]
        public Offer Create([FromBody] Offer offer)
        {
            return OfferServices.Create(offer);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Offer>), StatusCodes.Status200OK)]
        public List<Offer> GetAll()
        {
            return OfferServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Offer), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Offer), StatusCodes.Status400BadRequest)]
        public Offer Update([FromBody] Offer offer)
        {
            return OfferServices.Update(offer);
        }
        
        
        [AllowAnonymous]
        [HttpDelete("{id}")]
        public Offer Delete(int id)
        {
           return OfferServices.Delete(id);
        }
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("OfferSearch")]
        //[ProducesResponseType(typeof(List<Offer>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Offer>), StatusCodes.Status400BadRequest)]
        //public List<Offer> Search([FromBody] OfferDTO OfferDTO)
        //{
        //    return OfferServices.Search(OfferDTO);
        //}
        //[HttpGet]
        //[Route("GetAllOffer")]
        //[ProducesResponseType(typeof(List<Offer>), StatusCodes.Status200OK)]
        //public async Task<List<Offer>> GetAllOffer()
        //{
        //    return await OfferServices.GetAllOffer();
        //}
        // [HttpGet]
        // public JsonResult Get()
        // {
        //     string query = @"
        //             select O.Price,O.PetId,O.Category ,P.Id,P.caractristic FROM Pets as P left join Offer as O 
        //               on P.Id=O.PetId ";
        //     DataTable table = new DataTable();
        //     string sqlDataSource = _configuration.GetConnectionString("DBConnectionString");
        //     SqlDataReader myReader;
        //     using (SqlConnection myCon = new SqlConnection(sqlDataSource))
        //     {
        //         myCon.Open();
        //         using (SqlCommand myCommand = new SqlCommand(query, myCon))
        //         {
        //             myReader = myCommand.ExecuteReader();
        //             table.Load(myReader); ;
 
        //             myReader.Close();
        //             myCon.Close();
        //         }
        //     }
 
        //     return new JsonResult(table);
        // }
[HttpGet]

        [Route("GetAllCategoryName")]
        public JsonResult GetAllCategoryName()
        {
            string query = @"
                    select CategoryType from dbo.Category
                    ";
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
 
        [HttpGet]
        [Route("GetPetsInClinic")]
        public JsonResult GetPets(int id)
        {
            string query = @"
                      select p.Id, P.Name ,P.Age,P.Gender ,P.ClinincId from pets as P
                     where ClinicId='" + id + "'";
 
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
    }
}
