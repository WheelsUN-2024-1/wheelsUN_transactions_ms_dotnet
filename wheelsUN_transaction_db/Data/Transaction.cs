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
        public int transactionID { get; set; }
        [Required]
        public string referenceCode { get; set; }
        public string description { get; set; }
        [Required]
        public int value { get; set; }
        [Required]
        public string currency { get; set; }
        [Required]
        public string driverId { get; set; }
        [Required]
        public string driverName { get; set; }
        [Required]
        public string driverEmail { get; set; }
        [Required]
        public string driverPhone { get; set; }
        [Required]
        public string driverAddress { get; set; }
        [Required]
        public string driverCity { get; set; }
        [Required]
        public string driverHomephone { get; set; }
        [Required]
        public string driverCountry { get; set; }
        [Required]
        public string driverPostalCode { get; set; }
        [Required]
        public string userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string userEmail { get; set; }
        [Required]
        public string userPhone { get; set; }
        [Required]
        public string userAddress { get; set; }
        [Required]
        public string userCity { get; set; }
        [Required]
        public string userHomephone { get; set; }
        [Required]
        public string userCountry { get; set; }
        [Required]
        public string userPostalCode { get; set; }
        [Required]
        public string paymentMethod { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string transactionIdPay { get; set; }
        [Required]
        public int orderId { get; set; }

        [Required]
        public int creditCardId { get; set; }

        [ForeignKey("creditCardId")]
        public virtual CreditCard CreditCard { get; set; }

        [InverseProperty("Transactions")]
        public ICollection<CreditCard> CreditCards { get; set; }
    }
}
