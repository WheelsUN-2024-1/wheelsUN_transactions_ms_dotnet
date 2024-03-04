using wheelsUN_transactions_ms.Models;

namespace wheelsUN_transactions_ms.Services
{
    public interface ISTransaction
    {
        Task<string> GetData(string url, object payment);
        Task<object> PostCardPayment(RequestPayment payment);
        Task<object> GetPaymentMethods(PaymentMethod payment);


    }
}
