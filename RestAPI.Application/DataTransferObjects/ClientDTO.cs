using RestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Application.DataTransferObjects
{
    public class ClientDTO 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
