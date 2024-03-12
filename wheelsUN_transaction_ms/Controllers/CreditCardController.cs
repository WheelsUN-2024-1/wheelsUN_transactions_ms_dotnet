using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using wheelsUN_transaction_ms.Services;

namespace wheelsUN_transaction_ms.Controllers
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
        public async Task<IActionResult> PostCard([FromBody] wheelsUN_transaction_db.DTO.CreditCardDTO creditCard)
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
