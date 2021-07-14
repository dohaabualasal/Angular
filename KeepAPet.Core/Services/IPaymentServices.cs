using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
   public  interface IPaymentServices
    {
        Payment Create(Payment payment);
        List<Payment> GetAll();
        Payment Update(Payment payment);
        //Payment Delete(int id);
        //List<Payment> Search(PaymentDTO PaymentDTO);
        //Task<List<Payment>> GetAllPayment();
    }
}
