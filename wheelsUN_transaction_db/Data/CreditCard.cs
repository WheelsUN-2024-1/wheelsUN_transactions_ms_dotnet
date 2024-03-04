using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wheelsUN_transaction_db.Data
{
    public class CreditCard
    {
        public string number { get; set; }
        public int securityCode { get; set; }
        public string expirationDate { get; set; }
        
    }
}
