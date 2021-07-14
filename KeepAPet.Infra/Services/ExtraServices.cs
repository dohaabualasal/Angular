using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
   public  class ExtraServices:IExtraServices
    {
        private readonly IExtraRepository ExtraRepository;
        public ExtraServices(IExtraRepository extraRepository)
        {
            ExtraRepository = extraRepository;
        }
        public Extra Create(Extra Extra)
        {
            ExtraRepository.Create(Extra);
            return Extra;
        }
        public List<Extra> GetAll()
        {
            return ExtraRepository.GetAll();

        }
        public Extra Update(Extra Extra)
        {
            ExtraRepository.Update(Extra);
            return Extra;
        }
        //public Extra Delete(int id)
        //{
        //    ExtraRepository.Delete(id);
        //    return new Extra();
        //}
        //public List<Extra> Search(ExtraDTO ExtraDTO)
        //{
        //    return ExtraRepository.Search(ExtraDTO);
        //}
        //public async Task<List<Extra>> GetAllExtra()
        //{
        //    return await ExtraRepository.GetAllExtra();
        //}
    }
}
