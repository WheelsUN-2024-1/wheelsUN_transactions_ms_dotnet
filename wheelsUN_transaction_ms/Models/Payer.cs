namespace wheelsUN_transaction_ms.Models
{
    public class Payer
    {
        public string emailAddress { get; set; }
        public int merchantPayerId { get; set; }
        public string fullName { get; set; }

        public Address billingAddress { get; set; }
        public string birthdate { get; set; }

        public string contactPhone { get; set; }

        public string dniNumber { get; set; }

        public string dniType { get; set; }
    }
}
