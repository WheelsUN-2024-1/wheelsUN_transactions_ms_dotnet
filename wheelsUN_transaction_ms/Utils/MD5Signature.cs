using System.Security.Cryptography;
using System.Text;
using wheelsUN_transaction_ms.Models;

namespace wheelsUN_transaction_ms.Utils
{
    public class MD5Signature
    {
        public static string GetMD5(RequestPayment payment)
        {
            string signature = payment.merchant.apiKey + "~" + "508029" + "~" + payment.transaction.order.referenceCode +
                "~" + payment.transaction.order.additionalValues.TX_VALUE.value + "~" + payment.transaction.order.additionalValues.TX_VALUE.currency;

            using (MD5 md5 = MD5.Create())
            {
                // Convertir la entrada a bytes
                byte[] inputBytes = Encoding.UTF8.GetBytes(signature);

                // Calcular el hash MD5
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convertir el hash a una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
