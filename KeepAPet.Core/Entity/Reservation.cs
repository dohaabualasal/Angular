using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
    public class Reservation
    {
        public int Id { get; set; }
      
        public DateTime Date{ get; set; }
        public int CustomerId { get; set; }
        public int DoctorId { get; set; }

    }
}
