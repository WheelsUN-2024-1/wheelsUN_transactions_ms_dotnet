using wheelsUN_transaction_ms.Models;
using wheelsUN_transaction_ms.wheelsUN_transaction_db.Data;
using wheelsUN_transaction_ms.wheelsUN_transaction_db.DTO;

namespace wheelsUN_transaction_ms.Services
{
    public class MProfile: AutoMapper.Profile
    {
        public MProfile()
        {
            CreateMap<TransactionD, TransactionDTO>().ReverseMap();
            CreateMap<CreditCardD, CreditCardDTO>().ReverseMap();
        }
    }
}
