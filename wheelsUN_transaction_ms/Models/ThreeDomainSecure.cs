namespace wheelsUN_transaction_ms.Models
{
    public class ThreeDomainSecure
    {
        public bool embedded { get; set; }
        public int eci { get; set; }
        public string xid { get; set; }
        public string cavv { get; set; }

        public string directoryServerTransactionId { get; set; }
    }
}
