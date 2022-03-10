using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Domain.Entities
{
    public class Client : Base
    {
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime SignupDate { get; set; }
        public bool Active { get; set; }
    }
}
