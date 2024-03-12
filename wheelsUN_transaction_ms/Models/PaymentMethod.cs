namespace wheelsUN_transaction_ms.Models
{
    public class PaymentMethod
    {
        public string language { get; set; }
        public string command { get; set; }
        public bool test { get; set; }
        public Merchant merchant { get; set; }
    }
}
