using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wheelsUN_transaction_db.DTOs
{
    public class TransactionDTO
    {
        public int transactionId { get; set; }
        public string referenceCode { get; set; }
        public string description { get; set; }
        public int value { get; set; }
        public string paymentMethod { get; set; }
        public string state { get; set; }
        public string transactionIdPay { get; set; }
        public int orderId { get; set; }
        public int tripId { get; set; }
        public int creditCardId { get; set; }
    }
}
