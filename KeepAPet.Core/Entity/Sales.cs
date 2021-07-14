using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
    public class Sales
    {

        public int Id { get; set; }
        public int Quantity { get; set; }
        public float price { get; set; }
        public DateTime Date { get; set; }
        public int AccountantId { get; set; }
        public int PetId { get; set; }
        public int PaymentId { get; set; }

    }
}
