using System.ComponentModel.DataAnnotations.Schema;

namespace MyHardwareWeb.Domain.Models
{
    public class Product : Entity
    {
        [Column(TypeName = "varchar(45)")]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(130)")]
        public string? ProductType { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(30,2)")]
        public double Price { get; set; }
    }
}