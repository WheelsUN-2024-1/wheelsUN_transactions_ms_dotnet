using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text;
using wheelsUN_transaction_db.Data;
using wheelsUN_transaction_db.DTOs;
using wheelsUN_transactions_ms.Models;
using wheelsUN_transactions_ms.Utils;

namespace wheelsUN_transactions_ms.Services
{
    public class STransaction : ISTransaction
    {
        private readonly wheelsUN_transaction_context _context;
        private readonly IMapper _mapper;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly MapTransaction _mapTransaction;

        public STransaction(wheelsUN_transaction_context context, IMapper mapper,IServiceScopeFactory serviceScopeFactory, MapTransaction mapTransaction)
        {
            _context = context;
            _mapper = mapper;
            _serviceScopeFactory = serviceScopeFactory;
            _mapTransaction = mapTransaction;
        }
        public async Task<string> GetData(string url, object payment)
        {
            HttpClient Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var json = JsonConvert.SerializeObject(payment, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            Debug.WriteLine(json);
            var contenido = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
            var result = Client.PostAsync(url, contenido).Result;

            var resultBody = await result.Content.ReadAsStringAsync();
            return resultBody;
        }

        public async Task<Transaction> postTransaction(TransactionDTO transaction) {
            try {
                Transaction data = _mapper.Map<Transaction>(transaction);
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetService<wheelsUN_transaction_context>();
                    //Add ingresa la información en la entidad correspondiente
                    dbContext.Add(data);
                    await dbContext.SaveChangesAsync();
                }
                return data;
            }
            catch (Exception ex) {
                throw ex;
            }

        }
        public async Task<object> PostCardPayment(RequestPayment payment)
        {
            try
            {
                ResponseT asds = new ResponseT();
                payment.transaction.order.signature = MD5Signature.GetMD5(payment);
                var response = await GetData("https://sandbox.api.payulatam.com/payments-api/4.0/service.cgi", payment);
                var responseObject = JsonConvert.DeserializeObject<dynamic>(response);

                // Obtener el valor de la propiedad "state" y guardarlo en una variable
                string state = responseObject?.transactionResponse?.state;
                string transactionId = responseObject?.transactionResponse?.transactionId;
                string orderId = responseObject?.transactionResponse?.orderId;


                if (response != null)
                {

                    
                     TransactionDTO transaction = _mapTransaction.MapTransactions(payment, state, transactionId, orderId);
                     if (transaction != null)
                     {
                         var result = await postTransaction(transaction);
                     }


                    
                    return response;
                }
                else
                {
                    return null;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<Transaction> GetTransaction(string referenceCode) {
            try
            {
                Transaction data = await _context.Transactions.FirstOrDefaultAsync(x => x.referenceCode == referenceCode);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }


    }
}
