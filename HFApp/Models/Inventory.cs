namespace HFApp.Models
{
    public class Inventory
    {
        //List of products for each facility and number/quantity of units available
        public int InventoryId { get; set; }
        public int FacilityId { get; set; }
        public int ProductId { get; set; }
        public int BinLookupId { get; set; }
        public int Quantity { get; set; }
    }
}
