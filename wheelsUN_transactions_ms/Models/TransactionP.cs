namespace wheelsUN_transactions_ms.Models
{
    /// <summary>
    /// Modelo de datos para la transacción
    /// </summary>

    public class TransactionP
    {
        public Order order { get; set; }
        public CreditCard creditCard { get; set; }
        public Payer payer { get; set; }
        public string type { get; set; }
        public string paymentMethod { get; set; }
        public string paymentCountry { get; set; }
        public string deviceSessionId { get; set; }
        public string ipAddress { get; set; }
        public string cookie { get; set; }
        public string userAgent { get; set; }

        public ExtraParameters extraParameters { get; set; }
        
    }
}
