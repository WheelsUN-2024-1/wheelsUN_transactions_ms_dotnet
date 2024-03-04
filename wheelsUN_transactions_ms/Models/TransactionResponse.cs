namespace wheelsUN_transactions_ms.Models
{
    public class TransactionResponse
    {
        public int orderId { get; set; }
        public string transactionId { get; set; }
        public string state { get; set; }
        public object paymentNetworkResponseCode { get; set; }
        public object paymentNetworkResponseErrorMessage { get; set; }
        public object trazabilityCode { get; set; }
        public object authorizationCode { get; set; }
        public object pendingReason { get; set; }
        public string responseCode { get; set; }
        public object errorCode { get; set; }
        public object responseMessage { get; set; }
        public object transactionDate { get; set; }
        public object transactionTime { get; set; }
        public object operationDate { get; set; }
        public object referenceQuestionnaire { get; set; }
        public object extraParameters { get; set; }

    }
}
