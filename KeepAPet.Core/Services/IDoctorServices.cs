using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KeepAPets.Core.Services
{
    public interface IDoctorsServices
    {
        Doctors Create(Doctors Doctors);
        List<Doctors> GetAll();
        Doctors Update(Doctors Doctors);
        Doctors Delete(int id);
        //List<Doctors> Search(DiseasesDoctorsDTO DoctorsDTO);
        //Task<List<Doctors>> GetAllDoctors();
    }
}
