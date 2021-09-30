using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLearn.Helper
{
    public static class SpacedCapitalConverter
    {
        public static string ConvertAlphabet(this string from)
        {
            string res= "";
            for (int i = 0; i < from.Length; i++)
            {
                res += char.ToUpper(from[i]);
                res += " ";
            }
            return res;
        }
        public static string ConvertAlphabetTab(this string from)
        {
            string res = "";
            for (int i = 0; i < from.Length; i++)
            {
                res += char.ToUpper(from[i]);
                res += "   ";
            }
            return res;
        }
    }
}
