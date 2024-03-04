using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text;
using wheelsUN_transactions_ms.Models;
using wheelsUN_transactions_ms.Utils;

namespace wheelsUN_transactions_ms.Services
{
    public class STransaction : ISTransaction
    {

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

              
                if (response != null)
                {
                    
                    
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
        public async Task<object> GetPaymentMethods(PaymentMethod paymentMethod)
        {
            try
            {
                var response = await GetData("https://sandbox.api.payulatam.com/payments-api/4.0/service.cgi", paymentMethod);
                if (response != null)
                {
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

    }
}
