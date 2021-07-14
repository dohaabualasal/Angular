using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
  public  class Review
    {
        public int Id { get; set; }
        public string ReviewType { get; set; }
        public int  CustomerId { get; set; }

    }
}
