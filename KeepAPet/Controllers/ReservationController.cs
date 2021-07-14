using KeepAPets.Core.Entity;
using KeepAPets.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepAPets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : Controller
    {
        private readonly IReservationServices ReservationServices;
        public ReservationController(IReservationServices reservationServices)
        {
            ReservationServices = reservationServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Reservation), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Reservation), StatusCodes.Status400BadRequest)]
        public Reservation Create([FromBody] Reservation reservation)
        {
            return ReservationServices.Create(reservation);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Reservation>), StatusCodes.Status200OK)]
        public List<Reservation> GetAll()
        {
            return ReservationServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Reservation), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Reservation), StatusCodes.Status400BadRequest)]
        public Reservation Update([FromBody] Reservation reservation)
        {
            return ReservationServices.Update(reservation);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Reservations Delete(int id)
        //{
        //    return ReservationServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("ReservationSearch")]
        //[ProducesResponseType(typeof(List<Reservation>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Reservation>), StatusCodes.Status400BadRequest)]
        //public List<Reservation> Search([FromBody] ReservationDTO ReservationDTO)
        //{
        //    return ReservationServices.Search(ReservationDTO);
        //}
        //[HttpGet]
        //[Route("GetAllReservation")]
        //[ProducesResponseType(typeof(List<Reservation>), StatusCodes.Status200OK)]
        //public async Task<List<Reservation>> GetAllReservation()
        //{
        //    return await ReservationServices.GetAllReservation();
        //}
    }
}
