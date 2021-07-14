using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
   public  class JobTitleServices:IJobTitleServices
    {
        private readonly IJobTitleRepository JobTitleRepository;
        public JobTitleServices(IJobTitleRepository jobTitleRepository)
        {
            JobTitleRepository = jobTitleRepository;
        }
        public JobTitle Create(JobTitle JobTitle)
        {
            JobTitleRepository.Create(JobTitle);
            return JobTitle;
        }
        public List<JobTitle> GetAll()
        {
            return JobTitleRepository.GetAll();

        }
        public JobTitle Update(JobTitle JobTitle)
        {
            JobTitleRepository.Update(JobTitle);
            return JobTitle;
        }
        //public JobTitle Delete(int id)
        //{
        //    JobTitleRepository.Delete(id);
        //    return new JobTitle();
        //}
        //public List<JobTitle> Search(JobTitleDTO JobTitleDTO)
        //{
        //    return JobTitleRepository.Search(JobTitleDTO);
        //}
        //public async Task<List<JobTitle>> GetAllJobTitle()
        //{
        //    return await JobTitleRepository.GetAllJobTitle();
        //}
    }
}
