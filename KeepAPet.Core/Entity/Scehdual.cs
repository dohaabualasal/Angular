using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
   public class Scehdual
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string Name { get; set; }
         public string Email { get; set; }
          public string Phone { get; set; }
        public string TypeOfCounseling { get; set; }
        
        public DateTime ScehdualDate { get; set; }

    }
}
