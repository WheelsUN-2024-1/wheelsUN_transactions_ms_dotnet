using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace wheelsUN_transaction_ms.wheelsUN_transaction_db.Data
{
    public class TransactionD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int transactionId { get; set; }
        [Required]
        public string referenceCode { get; set; }
        public string description { get; set; }
        [Required]
        public int value { get; set; }
        [Required]
        public string paymentMethod { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string transactionIdPay { get; set; }

        public string orderId { get; set; }


        public int tripId { get; set; }


        public int creditCardId { get; set; }

        [ForeignKey("creditCardId")]
        public virtual CreditCardD CreditCardD { get; set; }
    }
}
