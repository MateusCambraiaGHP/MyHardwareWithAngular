using static MyHardware.Utility.Constants;

namespace MyHardware.ViewModel
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Description { get; set; }
        public string? Active { get; set; }
        public bool? IsActive { get { return Active == StatusActive.Active; } }
        public bool? IsNew { get { return Id == 0; } }
        public bool? IsEquals { get; set; }
    }
}