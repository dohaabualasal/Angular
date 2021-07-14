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
    public class JobTitleController : Controller
    {
        private readonly IJobTitleServices JobTitleServices;
        public JobTitleController(IJobTitleServices jobTitleServices)
        {
            JobTitleServices = jobTitleServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(JobTitle), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(JobTitle), StatusCodes.Status400BadRequest)]
        public JobTitle Create([FromBody] JobTitle jobTitle)
        {
            return JobTitleServices.Create(jobTitle);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<JobTitle>), StatusCodes.Status200OK)]
        public List<JobTitle> GetAll()
        {
            return JobTitleServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(JobTitle), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(JobTitle), StatusCodes.Status400BadRequest)]
        public JobTitle Update([FromBody] JobTitle jobTitle)
        {
            return JobTitleServices.Update(jobTitle);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public JobTitles Delete(int id)
        //{
        //    return JobTitleServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("JobTitleSearch")]
        //[ProducesResponseType(typeof(List<JobTitle>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<JobTitle>), StatusCodes.Status400BadRequest)]
        //public List<JobTitle> Search([FromBody] JobTitleDTO JobTitleDTO)
        //{
        //    return JobTitleServices.Search(JobTitleDTO);
        //}
        //[HttpGet]
        //[Route("GetAllJobTitle")]
        //[ProducesResponseType(typeof(List<JobTitle>), StatusCodes.Status200OK)]
        //public async Task<List<JobTitle>> GetAllJobTitle()
        //{
        //    return await JobTitleServices.GetAllJobTitle();
        //}
    }
}
