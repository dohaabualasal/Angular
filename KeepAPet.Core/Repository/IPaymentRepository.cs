using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
    public interface IPaymentRepository
    {
        int Create(Payment Data);
        List<Payment> GetAll();
        int Update(Payment Data);
        //int Delete(int id);
        // List<Payment> Search(PaymentDTO PaymentDTO);
        //Task<List<Payment>> GetAllPayment();
    }
}
