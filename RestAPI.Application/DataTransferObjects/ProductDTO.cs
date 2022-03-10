using RestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Application.DataTransferObjects
{
    public class ProductDTO 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
