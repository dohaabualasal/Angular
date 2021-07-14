using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
    public class DoctorsServices:IDoctorsServices
    {
        private readonly IDoctorsRepository DoctorsRepository;
        public DoctorsServices(IDoctorsRepository doctorsRepository)
        {
            DoctorsRepository = doctorsRepository;
        }
        public Doctors Create(Doctors Doctors)
        {
            DoctorsRepository.Create(Doctors);
            return Doctors;
        }
        public List<Doctors> GetAll()
        {
            return DoctorsRepository.GetAll();

        }
        public Doctors Update(Doctors Doctors)
        {
            DoctorsRepository.Update(Doctors);
            return Doctors;
        }
        public Doctors Delete(int id)
        {
            DoctorsRepository.Delete(id);
            return new Doctors();
        }
        //public List<Doctors> Search(DoctorsRateDTO DoctorsDTO)
        //{
        //    return DoctorsRepository.Search(DoctorsDTO);
        //}
        //public async Task<List<Doctors>> GetAllDoctors()
        //{
        //    return await DoctorsRepository.GetAllDoctors();
        //}
    }
}
