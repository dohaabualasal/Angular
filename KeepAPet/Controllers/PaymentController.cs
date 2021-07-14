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
    public class PaymentController : Controller
    {
        private readonly IPaymentServices PaymentServices;
        public PaymentController(IPaymentServices paymentServices)
        {
            PaymentServices = paymentServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status400BadRequest)]
        public Payment Create([FromBody] Payment Payment)
        {
            return PaymentServices.Create(Payment);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        public List<Payment> GetAll()
        {
            return PaymentServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status400BadRequest)]
        public Payment Update([FromBody] Payment Payment)
        {
            return PaymentServices.Update(Payment);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Payments Delete(int id)
        //{
        //    return PaymentServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("PaymentSearch")]
        //[ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Payment>), StatusCodes.Status400BadRequest)]
        //public List<Payment> Search([FromBody] PaymentDTO PaymentDTO)
        //{
        //    return PaymentServices.Search(PaymentDTO);
        //}
        //[HttpGet]
        //[Route("GetAllPayment")]
        //[ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        //public async Task<List<Payment>> GetAllPayment()
        //{
        //    return await PaymentServices.GetAllPayment();
        //}
    }
}
