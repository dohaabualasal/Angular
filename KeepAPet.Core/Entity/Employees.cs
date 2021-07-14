using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
  public   class Employees
    {
        
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public int JobTitleId { get; set; }
            public int LocationId { get; set; }
            public int RateId { get; set; }
        
    }
}
