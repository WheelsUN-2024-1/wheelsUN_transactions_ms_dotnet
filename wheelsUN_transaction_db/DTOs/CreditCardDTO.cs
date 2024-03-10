using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace wheelsUN_transaction_db.DTOs
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
