using System.ComponentModel.DataAnnotations;

namespace RestAPI.Domain.Entities
{
    public class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
