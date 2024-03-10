using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wheelsUN_transaction_db.Data
{
    public class CreditCard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int creditCardId { get; set; }
        public int userId { get; set; }
        public string number { get; set; }
        public string name { get; set; }
        public string securityCode { get; set; }
        public string expirationDate { get; set; }


    }
}
