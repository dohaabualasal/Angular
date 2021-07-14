using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
    public class Pets
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Biography { get; set; }
        public string Category{ get; set; }
        public string Image  { get; set; }
        public int ClinicId { get; set; }
        public int Price { get; set; }

    }
}
