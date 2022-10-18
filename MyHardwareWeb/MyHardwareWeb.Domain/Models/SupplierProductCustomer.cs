using System.ComponentModel.DataAnnotations.Schema;

namespace MyHardwareWeb.Domain.Models
{
    public class SupplierProductCustomer : Entity
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int CustomerId { get; set; }

        [Column(TypeName = "decimal(30,2)")]
        public double PurcashePrice { get; set; }
        public int PurcasheQuantity { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime PurchaseData { get; set; }
    }
}