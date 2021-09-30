using CryptoLearn.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLearn.Model
{
    class VigenereClass
    {
        public string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public string Key { get; set; }

        public ObservableCollection<string> ShiftedAlphabet
		{
			get
			{
				ObservableCollection<string> res = new ObservableCollection<string>();
				for (int i = 0; i < Alphabet.Length; i++)
				{
					res.Add(Alphabet.Substring(i) + Alphabet.Substring(0, i));
				}

				return res;
			}
		}

		#region Methods

		public string Encrypt(string plainText)
		{
				string key = new string(Enumerable.Repeat(Key.ToCharArray(), plainText.Length / Key.Length + 1).SelectMany(c => c).ToArray());
				key = key.Substring(0, plainText.Length);
				StringBuilder builder = new StringBuilder(plainText);
				for (int i = 0; i < plainText.Length; i++)
				{
					if (plainText[i] == ' ')
					{
						builder[i] = ' ';
						continue;
					}
					int pos1 = Alphabet.IndexOf(char.ToLower(plainText[i]));
					int pos2 = Alphabet.IndexOf(char.ToLower(key[i]));
					int pos = (pos1 + pos2) % Alphabet.Length;
					builder[i] = Alphabet[pos].Capitalize(plainText[i]);
				}
				return builder.ToString();
		}

		public string Decrypt(string plainText)
		{
			string key = new string(Enumerable.Repeat(Key.ToCharArray(), (plainText.Length / Key.Length) + 1).SelectMany(c => c).ToArray());
			key = key.Substring(0, plainText.Length);
			StringBuilder builder = new StringBuilder(plainText);
			for (int i = 0; i < plainText.Length; i++)
			{
				if (plainText[i] == ' ')
				{
					builder[i] = ' ';
					continue;
				}
				int pos1 = Alphabet.IndexOf(char.ToLower(plainText[i]));
				int localKey = Alphabet.IndexOf(char.ToLower(key[i]));
				int pos = (pos1 - localKey + Alphabet.Length) % Alphabet.Length;
				builder[i] = Alphabet[pos].Capitalize(plainText[i]);
			}
			return builder.ToString();
		}

		#endregion
	}
}
