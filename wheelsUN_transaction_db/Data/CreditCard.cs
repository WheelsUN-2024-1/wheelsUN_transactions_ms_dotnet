using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wheelsUN_transaction_db.Data
{
    public class CreditCard
    {
        public int creditCardId { get; set; }
        public int userId { get; set; }
        public string number { get; set; }

        public string name { get; set; }
        public int securityCode { get; set; }
        public string expirationDate { get; set; }

        [InverseProperty("CreditCards")]
        public Transaction Transactions { get; set; }

    }
}
