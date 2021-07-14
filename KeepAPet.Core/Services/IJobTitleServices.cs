using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
   public  interface IJobTitleServices
    {
        JobTitle Create(JobTitle jobTitle);
        List<JobTitle> GetAll();
        JobTitle Update(JobTitle jobTitle);
        //JobTitle Delete(int id);
        //List<JobTitle> Search(JobTitleDTO JobTitleDTO);
        //Task<List<JobTitle>> GetAllJobTitle();
    }
}
