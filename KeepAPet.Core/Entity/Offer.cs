using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
    public class Offer
    {
       public int OfferId { get; set; }
        public String Name { get; set; }
        public string Image { get; set; }
        public float OldPrice { get; set; }
        public float NewPrice { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string CategoryType { get; set; }
    }
}
