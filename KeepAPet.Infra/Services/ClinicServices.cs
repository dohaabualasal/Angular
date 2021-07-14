using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
    public class ClinicServices : IClinicServices
    {
        private readonly IClinicRepository ClinicRepository;
        public ClinicServices(IClinicRepository clinicRepository)
        {
            ClinicRepository = clinicRepository;
        }
        public Clinic Create(Clinic Clinic)
        {
            ClinicRepository.Create(Clinic);
            return Clinic;
        }
        public List<Clinic> GetAll()
        {
            return ClinicRepository.GetAll();

        }
        public Clinic Update(Clinic Clinic)
        {
            ClinicRepository.Update(Clinic);
            return Clinic;
        }
        public Clinic Delete(int id)
        {
            ClinicRepository.Delete(id);
            return new Clinic();
        }
        //public List<Clinic> Search(ClinicDTO ClinicDTO)
        //{
        //    return ClinicRepository.Search(ClinicDTO);
        //}
        //public async Task<List<Clinic>> GetAllClinic()
        //{
        //    return await ClinicRepository.GetAllClinic();
        //}
        public Scehdual Scedual(Scehdual Data)
        {
            ClinicRepository.Scedual(Data);
            return new Scehdual();

        }
    }
}
