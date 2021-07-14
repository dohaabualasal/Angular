using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
   public  class ReservationServices:IReservationServices
    {
        private readonly IReservationRepository ReservationRepository;
        public ReservationServices(IReservationRepository reservationRepository)
        {
            ReservationRepository = reservationRepository;
        }
        public Reservation Create(Reservation Reservation)
        {
            ReservationRepository.Create(Reservation);
            return Reservation;
        }
        public List<Reservation> GetAll()
        {
            return ReservationRepository.GetAll();

        }
        public Reservation Update(Reservation Reservation)
        {
            ReservationRepository.Update(Reservation);
            return Reservation;
        }
        //public Reservation Delete(int id)
        //{
        //    ReservationRepository.Delete(id);
        //    return new Reservation();
        //}
        //public List<Reservation> Search(ReservationDTO ReservationDTO)
        //{
        //    return ReservationRepository.Search(ReservationDTO);
        //}
        //public async Task<List<Reservation>> GetAllReservation()
        //{
        //    return await ReservationRepository.GetAllReservation();
        //}
    }
}
