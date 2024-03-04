using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wheelsUN_transaction_db.Data
{
    public class Transaction
    {
        
        public string referenceCode { get; set; }
        public string description { get; set; }
        public int value { get; set; }
        public string currency { get; set; }
        public string driverID { get; set; }

        public string driverName { get; set; }
        public string driverEmail { get; set; }
        public string driverPhone { get; set; }
        public string driverAddress { get; set; }
        public string driverCity { get; set; }
        public string driverHomephone { get; set; }
        public string driverCountry { get; set; }
        public string driverPostalCode { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPhone { get; set; }
        public string userAddress { get; set; }
        public string userCity { get; set; }
        public string userHomephone { get; set; }
        public string userCountry { get; set; }
        public string userPostalCode { get; set; }

        public string paymentMethod { get; set; }
        public string state { get; set; }
        public string transactionId { get; set; }
        public int orderId { get; set; }


    }
}
