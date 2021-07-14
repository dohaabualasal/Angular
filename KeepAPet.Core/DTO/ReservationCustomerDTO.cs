using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.DTOs
{
   public  class ReservationCustomerDTO
    {
        public string CustomerName { get; set; }
        public DateTime? DateForm { get; set; }
        public DateTime? DateTO { get; set; }
    }
}
