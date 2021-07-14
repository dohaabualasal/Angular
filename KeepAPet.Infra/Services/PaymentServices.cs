using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
   public  class PaymentServices:IPaymentServices
    {
        private readonly IPaymentRepository PaymentRepository;
        public PaymentServices(IPaymentRepository paymentRepository)
        {
            PaymentRepository = paymentRepository;
        }
        public Payment Create(Payment Payment)
        {
            PaymentRepository.Create(Payment);
            return Payment;
        }
        public List<Payment> GetAll()
        {
            return PaymentRepository.GetAll();

        }
        public Payment Update(Payment Payment)
        {
            PaymentRepository.Update(Payment);
            return Payment;
        }
        //public Payment Delete(int id)
        //{
        //    PaymentRepository.Delete(id);
        //    return new Payment();
        //}
        //public List<Payment> Search(PaymentDTO PaymentDTO)
        //{
        //    return PaymentRepository.Search(PaymentDTO);
        //}
        //public async Task<List<Payment>> GetAllPayment()
        //{
        //    return await PaymentRepository.GetAllPayment();
        //}
    }
}
