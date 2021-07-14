using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
    public interface IOfferServices
    {
        Offer Create(Offer offer);
        List<Offer> GetAll();
        Offer Update(Offer offer);
        Offer Delete(int id);
       
    }
    }