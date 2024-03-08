using wheelsUN_transaction_db.Data;
using wheelsUN_transaction_db.DTOs;

namespace wheelsUN_transactions_ms.Services
{
    public class MProfile:AutoMapper.Profile
    {
        public MProfile() {
            CreateMap<Transaction,TransactionDTO>().ReverseMap();
            CreateMap<CreditCard, CreditCardDTO>().ReverseMap();
        }
    }
}
