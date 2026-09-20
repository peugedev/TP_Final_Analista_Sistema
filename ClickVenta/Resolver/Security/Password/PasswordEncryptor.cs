using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolver.Security.Password
{
    public class PasswordEncryptor
    {

        private const int SaltSize = 32; // 128 bit
        private const int KeySize = 256; // 256 bit
        private const int Iterations = 10000; // Number of iterations for PBKDF2
        private const int IvSize = 16; // 128 bit

        /// <summary>
        /// Encripta un texto plano (contraseña) usando una clave maestra.
        /// </summary>
        /// <param name="plainText">Texto a encriptar.</param>
        /// <param name="masterPassword">Clave maestra (passphrase) que usará el usuario.</param>
        /// <returns>Cadena en Base64 que contiene: Salt + IV + Cifrado.</returns>

        public static string Encrypt(string plainText, string masterPassword)
        {
            using (var aes = System.Security.Cryptography.Aes.Create())
            {
                aes.KeySize = KeySize;
                aes.BlockSize = 128;
                aes.Mode = System.Security.Cryptography.CipherMode.CBC;
                aes.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
                // Generar un salt aleatorio
                var salt = new byte[SaltSize];
                using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
                {
                    rng.GetBytes(salt);
                }
                // Derivar la clave usando PBKDF2
                var key = new System.Security.Cryptography.Rfc2898DeriveBytes(masterPassword, salt, Iterations);
                aes.Key = key.GetBytes(KeySize / 8);
                // Generar un IV aleatorio
                aes.GenerateIV();
                var iv = aes.IV;
                using (var encryptor = aes.CreateEncryptor(aes.Key, iv))
                {
                    var plainBytes = Encoding.UTF8.GetBytes(plainText);
                    var cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                    // Combinar Salt + IV + Cifrado
                    var result = new byte[SaltSize + IvSize + cipherBytes.Length];
                    Buffer.BlockCopy(salt, 0, result, 0, SaltSize);
                    Buffer.BlockCopy(iv, 0, result, SaltSize, IvSize);
                    Buffer.BlockCopy(cipherBytes, 0, result, SaltSize + IvSize, cipherBytes.Length);
                    return Convert.ToBase64String(result);
                }
            }
        }

        /// <summary>
        /// Desencripta un texto cifrado previamente generado con Encrypt.
        /// </summary>
        /// <param name="cipherBase64">Cadena Base64 con Salt+IV+Cifrado.</param>
        /// <param name="masterPassword">Clave maestra (la misma usada para encriptar).</param>
        /// <returns>Texto plano original.</returns>
        public static string Decrypt(string cipherText, string masterPassword)
        {
            var fullCipher = Convert.FromBase64String(cipherText);
            // Extraer Salt + IV + Cifrado
            var salt = new byte[SaltSize];
            Buffer.BlockCopy(fullCipher, 0, salt, 0, SaltSize);
            var iv = new byte[IvSize];
            Buffer.BlockCopy(fullCipher, SaltSize, iv, 0, IvSize);
            var cipherBytes = new byte[fullCipher.Length - SaltSize - IvSize];
            Buffer.BlockCopy(fullCipher, SaltSize + IvSize, cipherBytes, 0, cipherBytes.Length);
            // Derivar la clave usando PBKDF2
            var key = new System.Security.Cryptography.Rfc2898DeriveBytes(masterPassword, salt, Iterations);
            using (var aes = System.Security.Cryptography.Aes.Create())
            {
                aes.KeySize = KeySize;
                aes.BlockSize = 128;
                aes.Mode = System.Security.Cryptography.CipherMode.CBC;
                aes.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
                aes.Key = key.GetBytes(KeySize / 8);
                aes.IV = iv;
                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    var plainBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                    return Encoding.UTF8.GetString(plainBytes);
                }
            }
        }
    }
}
