using Microsoft.AspNetCore.Mvc;
using wheelsUN_transaction_ms.Models;
using wheelsUN_transaction_ms.Services;

namespace wheelsUN_transaction_ms.Controllers
{
    [Route("api/Transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ISTransaction _transactions;

        public TransactionController(ISTransaction transactions)
        {
            _transactions = transactions;
        }

        [HttpPost]
        public async Task<IActionResult> PostCardPayment(RequestPayment payment)
        {
            try
            {
                var result = await _transactions.PostCardPayment(payment);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        [HttpGet]

        public async Task<IActionResult> GetTransaction(string referenceCode)
        {
            try
            {
                var result = await _transactions.GetTransaction(referenceCode);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
