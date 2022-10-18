using System.ComponentModel.DataAnnotations.Schema;

namespace MyHardwareWeb.Domain.Models
{
    public class SupplierProduct : Entity
    {
        public int IdSupplier { get; set; }
        public int IdProduct { get; set; }
    }
}