using CryptoLearn.Helper;
using System.Text;


namespace CryptoLearn
{
    class CeaserClass
    {
        private int _key;
        public string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

		public int Key { get => _key; set => _key = value; }

        public string ShiftedAlphabet => Alphabet.Substring(Key % Alphabet.Length) + Alphabet.Substring(0, Key % Alphabet.Length);

		#region Methods

		public string Encrypt(string plainText)
		{
			StringBuilder builder = new StringBuilder(plainText);
			for (int i = 0; i < plainText.Length; i++)
			{
				int pos = Alphabet.IndexOf(char.ToLower(plainText[i]));
				if (pos == -1) continue;
				pos = (pos + Key) % Alphabet.Length;
				builder[i] = Alphabet[pos].Capitalize(plainText[i]);
			}

			return builder.ToString();
		}

		public string Decrypt(string plainText)
		{
			StringBuilder builder = new StringBuilder(plainText);
			for (int i = 0; i < plainText.Length; i++)
			{
				int pos = Alphabet.IndexOf(char.ToLower(plainText[i]));
				if (pos == -1) continue;
				pos = (pos - Key + Alphabet.Length) % Alphabet.Length;
				builder[i] = Alphabet[pos].Capitalize(plainText[i]);
			}

			return builder.ToString();
		}
        #endregion
    }
}
