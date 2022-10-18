using System.ComponentModel.DataAnnotations.Schema;

namespace MyHardwareWeb.Domain.Models
{
    public class Customer : Entity
    {
        [Column(TypeName = "varchar(45)")]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string? Observation { get; set; }
    }
}