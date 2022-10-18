using System.ComponentModel.DataAnnotations.Schema;

namespace MyHardwareWeb.Domain.Models
{
    public class Adress : Entity
    {
        public int IdSupplier { get; set; }
        public int IdCustomer { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? City { get; set; }
        public int Number { get; set; }
    }
}