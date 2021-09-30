using CryptoLearn.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLearn.Model
{
    class VernamClass
    {
        private string _key;

        public string Key { get => _key; set => _key = value; }
        public string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

		#region Methods

		public string Encrypt(string plainText)
		{
			StringBuilder builder = new StringBuilder(plainText);
			for (int i = 0; i < plainText.Length; i++)
			{
				if (plainText[i] == ' ' || plainText[i] == ',' || plainText[i] == '.' || plainText[i] == '!' || plainText[i] == '?')
					builder[i] = plainText[i];
                else
                {
					int pos1 = Alphabet.IndexOf(char.ToLower(Key[i]));
					int pos2 = Alphabet.IndexOf(char.ToLower(plainText[i]));

					int pos = (pos1 + pos2) % Alphabet.Length;
					builder[i] = Alphabet[pos].Capitalize(plainText[i]);
				}
			}

			return builder.ToString();
		}

		public string Decrypt(string plainText)
		{
			StringBuilder builder = new StringBuilder(plainText);
			for (int i = 0; i < plainText.Length; i++)
			{
				if (plainText[i] == ' ' || plainText[i] == ',' || plainText[i] == '.' || plainText[i] == '!' || plainText[i] == '?')
					builder[i] = plainText[i];
				else
				{
					int pos1 = Alphabet.IndexOf(char.ToLower(Key[i]));
					int pos2 = Alphabet.IndexOf(char.ToLower(plainText[i]));
					int t = pos2 - pos1;
					if (t < 0)
						t += Alphabet.Length;
					int pos = t % Alphabet.Length;
					builder[i] = Alphabet[pos].Capitalize(plainText[i]);
				}
			}

			return builder.ToString();
		}


		#endregion
	}
}
