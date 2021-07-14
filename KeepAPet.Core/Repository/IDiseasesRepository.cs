using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
   public interface IDiseasesRepository
    {
        int Create(Diseases Data);
        List<Diseases> GetAll();
        int Update(Diseases Data);
        //int Delete(int id);
        // List<Diseases> Search(DiseasesDTO DiseasesDTO);
        //Task<List<Diseases>> GetAllDiseases();
    }
}
