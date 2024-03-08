using wheelsUN_transaction_db.Data;
using wheelsUN_transaction_db.DTOs;


namespace wheelsUN_transactions_ms.Services
{
    public interface ISCreditCard
    {
        Task<CreditCardDTO> GetCard(int id);
        Task<CreditCard> PostCard(CreditCardDTO creditCard);
    }
}
