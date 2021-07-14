using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
   public  interface IJobTitleRepository
    {
        int Create(JobTitle Data);
        List<JobTitle> GetAll();
        int Update(JobTitle Data);
        //int Delete(int id);
        // List<JobTitle> Search(JobTitleDTO JobTitleDTO);
        //Task<List<JobTitle>> GetAllJobTitle();
    }
}
