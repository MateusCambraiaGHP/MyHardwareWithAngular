using System.ComponentModel.DataAnnotations.Schema;

namespace MyHardwareWeb.Domain.Models
{
    public class Supplier : Entity
    {
        [Column(TypeName = "varchar(45)")]
        public string Name { get; set; } 

        [Column(TypeName = "varchar(130)")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Adress { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string Telephone { get; set; }
    }
}