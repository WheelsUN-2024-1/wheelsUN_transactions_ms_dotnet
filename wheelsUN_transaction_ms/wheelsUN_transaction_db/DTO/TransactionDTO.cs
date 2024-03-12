namespace wheelsUN_transaction_ms.wheelsUN_transaction_db.DTO
{
    public class TransactionDTO
    {
        public int transactionId { get; set; }
        public string referenceCode { get; set; }
        public string description { get; set; }
        public int value { get; set; }
        public string paymentMethod { get; set; }
        public string state { get; set; }
        public string transactionIdPay { get; set; }
        public string orderId { get; set; }
        public int tripId { get; set; }
        public int creditCardId { get; set; }
    }
}
