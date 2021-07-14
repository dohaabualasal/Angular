using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        //public int adminId { get; set; }
       // public int locationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string PartmentNum { get; set; }
        public string Image { get; set; }
        //public virtual Location Location { get; set; }
        //public virtual Employees Employees { get; set; }

    }
}
