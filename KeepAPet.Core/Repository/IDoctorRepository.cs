using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KeepAPets.Core.Repository
{
    public interface IDoctorsRepository
    {
        int Create(Doctors Data);
        List<Doctors> GetAll();
        int Update(Doctors Data);
        int Delete(int id);
        // List<Doctors> Search(DiseasesDoctorsDTO DoctorsDTO);
       // Task<List<Doctors>> GetAllDoctors();
    }
}
