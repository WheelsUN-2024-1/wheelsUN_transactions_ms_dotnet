using AutoMapper;
using wheelsUN_transaction_ms.Utils;
using wheelsUN_transaction_ms.wheelsUN_transaction_db.Data;
using wheelsUN_transaction_ms.wheelsUN_transaction_db.DTO;

namespace wheelsUN_transaction_ms.Services
{
    public class SCreditCard: ISCreditCard
    {
        private readonly wheelsUN_transaction_context _context;
        private readonly IMapper _mapper;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public SCreditCard(wheelsUN_transaction_context context, IMapper mapper, IServiceScopeFactory serviceScopeFactory)
        {
            _context = context;
            _mapper = mapper;
            _serviceScopeFactory = serviceScopeFactory;

        }

        public async Task<CreditCardDTO> GetCard(int id)
        {
            try
            {
                CreditCardD data = await _context.CreditCards.FindAsync(id);
                CreditCardDTO creditCard = _mapper.Map<CreditCardDTO>(data);
                creditCard.number = Encrypter.DecryptCreditCardNumber(creditCard.number);

                return creditCard;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CreditCardD> PostCard(CreditCardDTO creditCard)
        {
            try
            {
                CreditCardD data = _mapper.Map<CreditCardD>(creditCard);
                data.number = Encrypter.EncryptCreditCardNumber(data.number);
                data.securityCode = Encrypter.EncryptCreditCardNumber(data.securityCode);
                data.expirationDate = Encrypter.EncryptCreditCardNumber(data.expirationDate);

                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetService<wheelsUN_transaction_context>();
                    //Add ingresa la información en la entidad correspondiente
                    dbContext.Add(data);
                    await dbContext.SaveChangesAsync();
                }
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

