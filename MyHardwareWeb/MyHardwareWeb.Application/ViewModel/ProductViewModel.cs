using static MyHardware.Utility.Constants;

namespace MyHardware.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ProductType { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string? Active { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get { return Active == StatusActive.Active; } }
        public bool? IsNew { get { return Id == 0; } }
        public bool? IsEquals { get; set; }
    }
}