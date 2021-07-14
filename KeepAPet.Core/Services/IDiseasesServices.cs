using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
    public interface IDiseasesServices
    {
        Diseases Create(Diseases diseases);
        List<Diseases> GetAll();
        Diseases Update(Diseases diseases);
        //Diseases Delete(int id);
        //List<Diseases> Search(DiseasesDTO DiseasesDTO);
        //Task<List<Diseases>> GetAllDiseases();
    }
}
