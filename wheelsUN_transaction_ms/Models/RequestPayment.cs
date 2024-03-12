namespace wheelsUN_transaction_ms.Models
{
    public class RequestPayment
    {
        public string language { get; set; }
        public string command { get; set; }
        public bool test { get; set; }

        public Merchant merchant { get; set; }

        public TransactionP transaction { get; set; }
    }
}
