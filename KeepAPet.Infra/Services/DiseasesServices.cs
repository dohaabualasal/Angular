using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
    public class DiseasesServices:IDiseasesServices
    {
        private readonly IDiseasesRepository DiseasesRepository;
        public DiseasesServices(IDiseasesRepository diseasesRepository)
        {
            DiseasesRepository = diseasesRepository;
        }
        public Diseases Create(Diseases Diseases)
        {
            DiseasesRepository.Create(Diseases);
            return Diseases;
        }
        public List<Diseases> GetAll()
        {
            return DiseasesRepository.GetAll();

        }
        public Diseases Update(Diseases Diseases)
        {
            DiseasesRepository.Update(Diseases);
            return Diseases;
        }
        //public Diseases Delete(int id)
        //{
        //    DiseasesRepository.Delete(id);
        //    return new Diseases();
        //}
        //public List<Diseases> Search(DiseasesDoctorDTO DiseasesDTO)
        //{
        //    return DiseasesRepository.Search(DiseasesDTO);
        //}
        //public async Task<List<Diseases>> GetAllDiseases()
        //{
        //    return await DiseasesRepository.GetAllDiseases();
        //}
    }
}
