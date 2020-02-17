using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sisrute
{
    internal class Signature
    {
        /// <summary>
        /// Konversi timestamp
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Long</returns>
        internal static long ConvertToTimeStamp(DateTime value)
        {
            DateTime time = DateTime.SpecifyKind(new DateTime(0x7B2, 1, 1), DateTimeKind.Utc);
            TimeSpan span = (value.ToUniversalTime() - time);  // DirectCast((value.ToUniversalTime - time), TimeSpan)
            return System.Convert.ToInt64(Math.Floor(span.TotalSeconds));
        }

        /// <summary>
        /// Fungsi untuk men-generate signature
        /// </summary>
        /// <param name="sConsID">ConsID dari kementerian kesehatan</param>
        /// <param name="sPassword">Password dari kementerian kesehatan</param>
        /// <param name="sTimeStamp">Waktu saat eksekusi</param>
        /// <returns>String Signature</returns>
        internal static string GenerateSignature(string sConsID, string sPassword, string sTimeStamp)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = encoding.GetBytes(sPassword);
            string s = (sConsID + "&" + sTimeStamp);
            byte[] buffer = encoding.GetBytes(s);
            using (HMACSHA256 hmacsha = new HMACSHA256(bytes))
            {
                return Convert.ToBase64String(hmacsha.ComputeHash(buffer));
            }
        }
        
    }
}
