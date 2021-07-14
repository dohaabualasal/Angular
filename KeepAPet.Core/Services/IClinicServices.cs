using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
    public interface IClinicServices
    {
        Clinic Create(Clinic clinic);
        List<Clinic> GetAll();
        Clinic Update(Clinic clinic);
        Clinic Delete(int id);
        Scehdual Scedual(Scehdual Data);
        //List<Clinic> Search(DoctorClinicDTO ClinicDTO);
        //Task<List<Clinic>> GetAllClinic();
    }
}
