using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
  public   interface IClinicRepository
    {
        int Create(Clinic Data);
        int Scedual(Scehdual Data);
        List<Clinic> GetAll();
        int Update(Clinic Data);
        int Delete(int id);
        // List<Clinic> Search(DoctorClinicDTO clinicDTO);
        //Task<List<Clinic>> GetAllClinic();
    }
}
