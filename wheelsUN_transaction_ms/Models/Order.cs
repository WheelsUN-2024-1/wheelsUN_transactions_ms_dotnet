namespace wheelsUN_transaction_ms.Models
{
    public class Order
    {
        public int accountId { get; set; }
        public string referenceCode { get; set; }
        public string description { get; set; }

        public string language { get; set; }
        public string notifyUrl { get; set; }
        public string partnerId { get; set; }
        public string signature { get; set; }
        public Address shippingAddress { get; set; }

        public Buyer buyer { get; set; }
        public AdditionalValues additionalValues { get; set; }
    }
}
