namespace wheelsUN_transactions_ms.Models
{
    public class CreditCard
    {
        public string number { get; set; }
        public int securityCode { get; set; }
        public string expirationDate { get; set; }
        public string name { get; set; }
        public bool processWithoutCvv2 { get; set; }
    }
}
