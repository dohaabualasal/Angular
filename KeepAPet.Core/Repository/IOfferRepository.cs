using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
    public interface IOfferRepository
    {
        int Create(Offer Data);
        List<Offer> GetAll();
        int Update(Offer Data);
        int Delete(int id);
    }
}
