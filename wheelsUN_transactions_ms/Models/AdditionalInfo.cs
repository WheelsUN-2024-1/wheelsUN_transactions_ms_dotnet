namespace wheelsUN_transactions_ms.Models
{
    public class AdditionalInfo
    {
        public object paymentNetwork { get; set; }
        public object rejectionType { get; set; }

        public object responseNetworkMessage { get; set; }
        public object travelAgencyAuthorizationCode { get; set; }
        public object cardType { get; set; }
        public object transactionType { get; set; }
    }
}
