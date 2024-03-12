using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace wheelsUN_transaction_ms.wheelsUN_transaction_db.Data
{
    public class CreditCardD
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
