using wheelsUN_transaction_ms.Models;
using wheelsUN_transaction_ms.wheelsUN_transaction_db.Data;

namespace wheelsUN_transaction_ms.Services
{
    public interface ISTransaction
    {
        Task<string> GetData(string url, object payment);
        Task<object> PostCardPayment(RequestPayment payment);

        Task<TransactionD> GetTransaction(string referenceCode);
    }
}
