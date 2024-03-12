namespace wheelsUN_transaction_ms.Models
{
    public class Buyer
    {
        public string merchantBuyerId { get; set; }
        public string fullName { get; set; }
        public string emailAddress { get; set; }
        public string dniNumber { get; set; }
        public Address shippingAddress { get; set; }
    }
}
