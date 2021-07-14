using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
    public interface IReservationRepository
    {
        int Create(Reservation Data);
        List<Reservation> GetAll();
        int Update(Reservation Data);
        //int Delete(int id);
        // List<Reservation> Search(ReservationDTO ReservationDTO);
        //Task<List<Reservation>> GetAllReservation();
    }
}
