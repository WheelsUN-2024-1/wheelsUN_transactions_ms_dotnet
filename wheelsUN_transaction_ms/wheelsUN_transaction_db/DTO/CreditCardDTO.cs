using System.ComponentModel.DataAnnotations;

namespace wheelsUN_transaction_ms.wheelsUN_transaction_db.DTO
{
    public class CreditCardDTO
    {
        public int creditCardId { get; set; }
        [Required]
        public int userId { get; set; }
        [Required]
        public string number { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string securityCode { get; set; }
        [Required]
        public string expirationDate { get; set; }
    }
}
