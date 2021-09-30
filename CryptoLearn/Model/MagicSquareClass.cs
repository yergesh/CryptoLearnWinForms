using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLearn.Model
{
    class MagicSquareClass
    {
        public int[,] FillRandomNumberMatrix { get; set; }
        public List<KeyValuePair<int,char>> FillRandomCharMatrix { get; set; }

        #region Methods

        public string Encrypt(string plainText)
        {
            Random random = new Random();
            List<int> t = new List<int>();
            for (int i = 0; i < plainText.Length; i++)
            {
                t.Add(i);
            }

            int N = (int)Math.Sqrt(plainText.Length);
            FillRandomNumberMatrix = new int[N, N];
            FillRandomCharMatrix = new List<KeyValuePair<int, char>>();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int r = random.Next(0, t.Count - 1);
                    FillRandomNumberMatrix[i, j] = t[r];
                    FillRandomCharMatrix.Add(new KeyValuePair<int, char>(t[r], plainText[t[r]]));
                    t.RemoveAt(r);
                }
            }

            string res = "";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    res += plainText[FillRandomNumberMatrix[i, j]];
                }
            }
            return res;
        }

        public string Decrypt(string plainText)
        {
            FillRandomCharMatrix = FillRandomCharMatrix.OrderBy(o => o.Key).ToList();
            string res = "";
            int N = (int)Math.Sqrt(plainText.Length);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    res += FillRandomCharMatrix[i*N + j].Value;
                }
            }
            return res;
        }
        #endregion
    }
}
