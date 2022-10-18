using MyHardwareWeb.Domain.Models;
using static MyHardware.Utility.Constants;

namespace MyHardware.ViewModel
{
    public class AdressViewModel
    {
        public int Id { get; set; }
        public int IdSupplier { get; set; }
        public int IdCustomer { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public int Number { get; set; }
        public string? Active { get; set; }
        public bool? IsActive { get { return Active == StatusActive.Active;  } }
        public bool? IsNew { get { return Id == 0; } }
        public bool? IsEquals { get; set; }
        public Supplier? supplier { get; set; }
        public Customer? customer { get; set; }
    }
}