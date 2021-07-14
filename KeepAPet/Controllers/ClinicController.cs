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
    public class ClinicController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;

       // private readonly IDBContext DBContext;
        private readonly IConfiguration _configuration;


        private readonly IClinicServices ClinicServices;
        public ClinicController(IClinicServices clinicServices, IConfiguration configuration, IWebHostEnvironment env)
        {
            ClinicServices = clinicServices;
            _configuration = configuration;
            _env = env;
        }
        [HttpGet]
        [Route("GetReservation")]
        public JsonResult GetReservation(int id)
        {
            string query = @"
                   	select 
S.Name,S.Phone,S.Id ,S.Email , S.ScehdualDate, D.Name
from Scehdual  as S inner join Doctor as d on S.DoctorId=d.Id
where d.clinicid='" + id + "'";

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



        [HttpDelete]
        [Route("DeleteReservation")]
        public JsonResult DeleteReservation(int id)
        {
            string query = @"
                   	delete from Scehdual where Id='" + id + "'";

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
        [ProducesResponseType(typeof(Clinic), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Clinic), StatusCodes.Status400BadRequest)]
        public Clinic Create([FromBody] Clinic clinic)
        {

            return ClinicServices.Create(clinic);
        }
        ////[HttpGet]
        //[ProducesResponseType(typeof(List<Clinic>), StatusCodes.Status200OK)]
        //public List<Clinic> GetAll()
        //{
        //    return ClinicServices.GetAll();
        //}


        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                    select C.Id,C.Name,C.email,C.Phone,C.Image ,A.FullName  as 'Admin Name',C.Country,C.City,C.Building ,C.Street,C.PartmentNum FROM Clinic as C  left join Employees as A 
                      on C.adminid=A.Id ";
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
        [Route("GetDoctors")]
        public JsonResult GetDoctors(int id)
        {
            string query = @"
                   	select  D.Name, D.Email ,D.phone,D.Id , D.RateNumber from Doctors as D 
                     where clinicid='" + id + "'";

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



        [HttpPut]
        [ProducesResponseType(typeof(Clinic), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Clinic), StatusCodes.Status400BadRequest)]
        public Clinic Update([FromBody] Clinic clinic)
        {
            return ClinicServices.Update(clinic);
        }
        [AllowAnonymous]
        [HttpDelete("{id}")]
        public Clinic Delete(int id)
        {
            return ClinicServices.Delete(id);
        }
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("ClinicSearch")]
        //[ProducesResponseType(typeof(List<Clinic>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Clinic>), StatusCodes.Status400BadRequest)]
        //public List<Clinic> Search([FromBody] ClinicDTO ClinicDTO)
        //{
        //    return ClinicServices.Search(ClinicDTO);
        //}
        //[HttpGet]
        //[Route("GetAllClinic")]
        //[ProducesResponseType(typeof(List<Clinic>), StatusCodes.Status200OK)]
        //public async Task<List<Clinic>> GetAllClinic()
        //{
        //    return await ClinicServices.GetAllClinic();
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
        [Route("RateDoctor")]
        public JsonResult RateDoctor(int id)
        {
            string query = @" 	update Doctors set RateNumber = RateNumber+1
where id='" + id + "'";

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
        [Route("Scehdual")]

        public Scehdual Scehdual([FromBody] Scehdual scehdual)
        {

            return ClinicServices.Scedual(scehdual);
        }

        [HttpGet]
        [Route("Sales")]
        public JsonResult Sales()
        {
            string query = @"select * from BookPet";

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
        [Route("Profit")]
        public JsonResult Profit()
        {
            string query = @"select SUM(Price) as 'Profit'
from Pets 
where Available=0";

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
        [Route("ClinicInfo")]
        public JsonResult ClinicInformation(int id)
        {
            string query = @"select * from clinic where =id='" + id + "'";

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

        

    }
}
