using System.ComponentModel.DataAnnotations.Schema;

namespace MyHardwareWeb.Domain.Models
{
    public class User : Entity
    {
        public int IdCustomer { get; set; }
        public int IdSupplier { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string? Email { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string Token { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string? Password { get; set; }
    }
}