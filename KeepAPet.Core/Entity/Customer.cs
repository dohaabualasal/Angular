using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int BillId { get; set; }
        public int LocationId { get; set; }
    
    }
}
