using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using wheelsUN_transaction_db.Data;
using wheelsUN_transaction_db.DTOs;
using wheelsUN_transactions_ms.Utils;

namespace wheelsUN_transactions_ms.Services
{
    public class SCreditCard:ISCreditCard
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
                CreditCard data = await _context.CreditCards.FindAsync(id);
                CreditCardDTO creditCard = _mapper.Map<CreditCardDTO>(data);

                return creditCard;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CreditCard> PostCard(CreditCardDTO creditCard) {
            try
            {
                CreditCard data = _mapper.Map<CreditCard>(creditCard);
                data.number = Encrypter.MaskCreditCardNumber(data.number);
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
