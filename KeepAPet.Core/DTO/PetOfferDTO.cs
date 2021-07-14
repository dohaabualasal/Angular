using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.DTOs
{
    public class PetOfferDTO
    {
        public string PetName { get; set; }
        public float PriceFrom { get; set; }
        public float PriceTO { get; set; }
    }
}
