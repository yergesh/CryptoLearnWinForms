using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLearn.Helper
{
    public static class LocalValue
    {
        public static bool InputIsLocalValue(this string from)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            for (int i = 0; i < from.Length; i++)
            {
                if (from[i] == ' ' || from[i] == ',' || from[i] == '.' || from[i] == '!' || from[i] == '?') continue;
                if (alphabet.IndexOf(char.ToLower(from[i])) == -1) return false;
            }
            return true;
        }
    }
}
