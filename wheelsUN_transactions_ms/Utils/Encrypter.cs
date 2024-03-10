using System;
using System.Security.Cryptography;
using System.Text;

namespace wheelsUN_transactions_ms.Utils
{
    public class Encrypter
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("as@.@#XDilfont12");

        private static readonly byte[] IV = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F };

        public static string EncryptCreditCardNumber(string creditCardNumber)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Crear un objeto de cifrado para realizar la operación de cifrado
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Convertir el número de tarjeta de crédito en bytes
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(creditCardNumber);

                // Cifrar los bytes
                byte[] cipherTextBytes = encryptor.TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);

                // Convertir los bytes cifrados en una cadena base64 para almacenar en la base de datos
                string encryptedText = Convert.ToBase64String(cipherTextBytes);

                return encryptedText;
            }
        }

        public static string DecryptCreditCardNumber(string encryptedCreditCardNumber)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Crear un objeto de descifrado para realizar la operación de descifrado
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Convertir la cadena base64 cifrada en bytes
                byte[] cipherTextBytes = Convert.FromBase64String(encryptedCreditCardNumber);

                // Descifrar los bytes
                byte[] decryptedBytes = decryptor.TransformFinalBlock(cipherTextBytes, 0, cipherTextBytes.Length);

                // Convertir los bytes descifrados en una cadena UTF-8
                string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                return decryptedText;
            }
        }

        public static string MaskCreditCardNumber(string creditCardNumber)
        {
            if (creditCardNumber.Length < 4)
                throw new ArgumentException("El número de tarjeta de crédito es demasiado corto.");

            // Mantener los últimos cuatro dígitos sin encriptar
            string lastFourDigits = creditCardNumber.Substring(creditCardNumber.Length - 4);

            // Encriptar el resto de los dígitos
            string encryptedPart = EncryptCreditCardNumber(creditCardNumber.Substring(0, creditCardNumber.Length - 4));

            // Retornar la concatenación de los dígitos encriptados y los últimos cuatro dígitos sin encriptar
            return $"{encryptedPart} {lastFourDigits}";
        }
    }
}
