namespace MyHardware.ViewModel
{
    public class SupplierProductCustomerViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int CustomerId { get; set; }
        public int PurcashePrice { get; set; }
        public int PurcasheQuantity { get; set; }
        public SupplierViewModel supplier { get; set; }
        public ProductViewModel product { get; set; }
        public CustomerViewModel customer { get; set; }
        public DateTime PurchaseData { get; set; }
    }
}