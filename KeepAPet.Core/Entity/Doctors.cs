using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
    public class Doctors
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int ClinicId { get; set; }
              //public string schedule { get; set; }
    }
}
