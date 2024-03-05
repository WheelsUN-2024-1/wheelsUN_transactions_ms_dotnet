namespace wheelsUN_transactions_ms.Models
{
    /// <summary>
    /// Modelo de datos para la solicitud de pago
    /// </summary>
    public class RequestPayment
    {
        public string language { get; set; }
        public string command { get; set; }
        public bool test { get; set; }

        public Merchant merchant { get; set; }

        public TransactionP transaction { get; set; }
    }
}
