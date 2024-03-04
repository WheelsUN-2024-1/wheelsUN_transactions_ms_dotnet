namespace wheelsUN_transactions_ms.Models
{
    /// <summary>
    /// Modelo de datos para el comprador
    /// </summary>
    public class Buyer
    {
        public string merchantBuyerId { get; set; }
        public string fullName { get; set; }
        public string emailAddress { get; set; }
        public string dniNumber { get; set; }
        public Address shippingAddress { get; set; }
    }
}
