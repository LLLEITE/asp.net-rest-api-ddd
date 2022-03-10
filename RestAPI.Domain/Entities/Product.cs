using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RestAPI.Domain.Entities
{
    public class Product : Base
    {
        public decimal Value { get; set; }
        public bool Available { get; set; }
    }
}
