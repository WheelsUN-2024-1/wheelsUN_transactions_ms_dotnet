using wheelsUN_transaction_db.Data;
using wheelsUN_transactions_ms.Models;

namespace wheelsUN_transactions_ms.Services
{
    public interface ISTransaction
    {
        Task<string> GetData(string url, object payment);
        Task<object> PostCardPayment(RequestPayment payment);

        Task<Transaction> GetTransaction(string referenceCode);
        


    }
}
