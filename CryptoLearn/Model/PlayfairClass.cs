using CryptoLearn.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLearn.Model
{
    class PlayfairClass
    {
        private string _key;

        public string Key { get => _key; set => _key = value; }

        public string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщыьэюя";
		
		public string GenerateTable()
        {
			string res = "";
            for (int i = 0; i < Key.Length; i++)
            {
				if (!res.Contains(Key[i]))
					res += Key[i];
            }

            for (int i = 0; i < Alphabet.Length; i++)
            {
				if (!res.Contains(Alphabet[i]))
					res += Alphabet[i];
			}
			return res;
        }
		
		public string GenerateBigramma(string plaintext)
        {
			string res = "";
			if (plaintext.Length % 2 != 0) plaintext += "я";
            for (int i = 0; i < plaintext.Length; i+=2)
            {
				res += plaintext[i].Capitalize(plaintext[i]).ToString();
				res += plaintext[i + 1].Capitalize(plaintext[i]).ToString();
				res+=" ";
            }
			return res;
        }

		public string Encrypt(string plaintext)
        {
			string res = "";
			string table = GenerateTable();
			string bigramma = GenerateBigramma(plaintext);

			char[,] ttable = new char[4, 8];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
					ttable[i, j] = table[i * 8 + j];
                }
            }

            for (int i = 0; i < bigramma.Length; i+=3)
            {
				char f = char.ToLower(bigramma[i]);
				char s = char.ToLower(bigramma[i + 1]);
				int pos1_i = 0, pos1_j = 0, pos2_i = 0, pos2_j = 0;

                for (int k = 0; k < 4; k++)
                {
                    for (int j = 0; j < 8; j++)
                    {
						if(ttable[k,j] == f)
                        {
							pos1_i = k;
							pos1_j = j;
                        }

						if (ttable[k, j] == s)
						{
							pos2_i = k;
							pos2_j = j;
						}
					}
                }

				res += (ttable[pos1_i, pos2_j]).Capitalize(bigramma[i]).ToString();
				res += (ttable[pos2_i, pos1_j]).Capitalize(bigramma[i+1]).ToString();

			}
			return res;
        }

		public string Decrypt(string plainText)
		{
			string res = "";
			string table = GenerateTable();
			string bigramma = GenerateBigramma(plainText);

			char[,] ttable = new char[4, 8];
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					ttable[i, j] = table[i * 8 + j];
				}
			}

			for (int i = 0; i < bigramma.Length; i += 3)
			{
				char f = char.ToLower(bigramma[i]);
				char s = char.ToLower(bigramma[i + 1]);
				int pos1_i = 0, pos1_j = 0, pos2_i = 0, pos2_j = 0;

				for (int k = 0; k < 4; k++)
				{
					for (int j = 0; j < 8; j++)
					{
						if (ttable[k, j] == f)
						{
							pos1_i = k;
							pos1_j = j;
						}

						if (ttable[k, j] == s)
						{
							pos2_i = k;
							pos2_j = j;
						}
					}
				}

				res += (ttable[pos1_i, pos2_j]).Capitalize(bigramma[i]).ToString();
				res += (ttable[pos2_i, pos1_j]).Capitalize(bigramma[i + 1]).ToString();

			}
			return res;
		}
	}
}
