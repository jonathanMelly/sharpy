//Auteur : JMY
//Date   : 10.1.2022
//Lieu   : ETML
//Descr. : Abstraction de code C# utile pour les débutants...
using System.Security.Cryptography;
using System.Text;

namespace Sharpy
{
    public class Security
    {
        /// <summary>
        /// Convert a string into a sha256 string
        /// </summary>
        /// <param name="input">string to hash</param>
        /// <param name="toBase64">use base64 for byte encoding (more readable)</param>
        /// <returns>a string corresponding to hash data</returns>
        public static string sha256(string input,bool toBase64=true)
        {
            using (var hashGenerator = SHA256.Create())
            {
                var hash = hashGenerator.ComputeHash(input.Select(c=>(byte)c).ToArray());

                //SHA-256 is 256 bits long, thus 32 byte...
                if (toBase64)
                {
                    //Uses More space (256/6=~43 chars) but more readable
                    return Convert.ToBase64String(hash);
                }

                //With Latin1 (1byte per character), we have a possible conversion for storing
                //into string type column in DB
                return Encoding.Latin1.GetString(hash);
            }
        }
    }
}
