using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SealedClass
{
    internal sealed class StringUtilities
    {
        public int GetLength(string str)
        {
            return str.Length;
        }

        public string ChangeCase(string str, char c)
        {
            if(c == 'L' || c == 'l') return str.ToLower();
            if (c == 'U' || c == 'u') return str.ToUpper();
            return str;
        }
    }


    internal static class StringUtilitiesExtended
    {
        public static string ReverseExt(this StringUtilities s, string str)
        {
            if (str == null || str.Length ==0) return "Input string is null";

            string reverse = String.Empty;

            for (int i = str.Length -1 ;i>= 0 ;i--) 
            {
                reverse += str[i];
            }

            return reverse;
        }
        /// <summary>
        /// Extension method for standard String class
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int GetWhiteSpaceCount(this string str)
        {
            int whiteSpaceCount = 0;
            if (String.IsNullOrEmpty(str))
            {
                return 0;
            }

            for (int i = 0; i < str.Length; i++)
            {
                
                if (Char.IsWhiteSpace(str[i]))
                {
                    whiteSpaceCount++;
                }
            }

            return whiteSpaceCount;
        }
    }

    
}
