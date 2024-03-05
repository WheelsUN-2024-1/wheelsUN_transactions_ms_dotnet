using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wheelsUN_transaction_db.Data
{
    public class Transaction
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
        [Required]
        public int orderId { get; set; }

        [Required]
        public int tripId { get; set; }

        [Required]
        public int creditCardId { get; set; }

        [ForeignKey("creditCardId")]
        public virtual CreditCard CreditCard { get; set; }

        [InverseProperty("Transactions")]
        public ICollection<CreditCard> CreditCards { get; set; }
    }
}
