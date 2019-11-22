using System;
using System.Text;

namespace LibreriaBase64
{
    public class LibraryB64
    {
        public static string Base64()
        {
            string toEncode = "alex";
            byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(toEncode);

            string returnValue = Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;
        }
    }
}
