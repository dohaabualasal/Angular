using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
    public class OfferServices:IOfferServices
    {
        private readonly IOfferRepository OfferRepository;
        public OfferServices(IOfferRepository offerRepository)
        {
            OfferRepository = offerRepository;
        }
        public Offer Create(Offer Offer)
        {
            OfferRepository.Create(Offer);
            return Offer;
        }
        public List<Offer> GetAll()
        {
            return OfferRepository.GetAll();

        }
        public Offer Update(Offer Offer)
        {
            OfferRepository.Update(Offer);
            return Offer;
        }
        public Offer Delete(int id)
        {
           OfferRepository.Delete(id);
           return new Offer();
        }
        //public List<Offer> Search(OfferDTO OfferDTO)
        //{
        //    return OfferRepository.Search(OfferDTO);
        //}
        //public async Task<List<Offer>> GetAllOffer()
        //{
        //    return await OfferRepository.GetAllOffer();
        //}
    }
}
