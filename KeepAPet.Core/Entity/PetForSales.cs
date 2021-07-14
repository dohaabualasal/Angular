using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
    public class PetForSales
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public float Price { get; set; }
        public string Age { get; set; }
        public int CategoryId{ get; set; }
        public char Gender { get; set; }
        public int AdminId{ get; set; }
        public string Biography { get; set; }
        public string Characteristic { get; set; }
    }
}
