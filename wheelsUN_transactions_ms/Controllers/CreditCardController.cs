
using Microsoft.AspNetCore.Mvc;
using wheelsUN_transaction_db.Data;
using wheelsUN_transaction_db.DTOs;
using wheelsUN_transactions_ms.Services;

namespace wheelsUN_transactions_ms.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController:ControllerBase
    {
        private readonly ISCreditCard _creditCard;

        public CreditCardController(ISCreditCard creditCard)
        {
            _creditCard = creditCard;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCard(int id)
        {
            try     
            {
                var result = await _creditCard.GetCard(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostCard([FromBody] CreditCardDTO creditCard)
        {
            try
            {
                var result = await _creditCard.PostCard(creditCard);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
