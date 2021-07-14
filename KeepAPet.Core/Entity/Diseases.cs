using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
  public   class Diseases
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DoctorId { get; set; }
        public string Subtoms { get; set; }
        public int ClinkId { get; set; }
    }
}
