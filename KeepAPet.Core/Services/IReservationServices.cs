using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
   public  interface IReservationServices
    {
        Reservation Create(Reservation reservation);
        List<Reservation> GetAll();
        Reservation Update(Reservation reservation);
       // Reservation Delete(int id);
        //List<Reservation> Search(ReservationDTO ReservationDTO);
        //Task<List<Reservation>> GetAllReservation();
    }
}
