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
        /// Convert a string into a sha256 binary string 
        /// </summary>
        /// <param name="input">string to hash</param>
        /// <param name="optimize">use ISO-8859-1 binary encoding</param>
        /// <returns>a sha256 hashed representation of input</returns>
        public static string sha256(string input,bool optimize=false)
        {
            using (var hashGenerator = SHA256.Create())
            {
                var hash = hashGenerator.ComputeHash(Encoding.UTF8.GetBytes(input));

                if (!optimize)
                {
                    return BitConverter.ToString(hash);
                }

                //Latin1 is 1byte per character, thus 32 characters long hash (smaller than hexa)
                return Encoding.Latin1.GetString(hash);
            }
        }
    }
}
