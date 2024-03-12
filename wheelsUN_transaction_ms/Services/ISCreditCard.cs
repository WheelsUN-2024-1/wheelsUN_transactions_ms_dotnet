using wheelsUN_transaction_ms.wheelsUN_transaction_db.Data;
using wheelsUN_transaction_ms.wheelsUN_transaction_db.DTO;

namespace wheelsUN_transaction_ms.Services
{
    public interface ISCreditCard
    {
        Task<CreditCardDTO> GetCard(int id);
        Task<CreditCardD> PostCard(CreditCardDTO creditCard);
    }
}
