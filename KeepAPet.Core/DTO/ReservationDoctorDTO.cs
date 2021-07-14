using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.DTOs
{
   public  class ReservationDoctorDTO
    {
        public string DoctorName { get; set; }
        public DateTime? DateForm { get; set; }
        public DateTime? DateTO { get; set; }
    }
}
