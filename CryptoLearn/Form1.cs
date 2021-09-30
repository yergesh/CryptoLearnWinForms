using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoLearn.Helper;
using CryptoLearn.Model;

namespace CryptoLearn
{
    public partial class Form1 : Form
    {
        CeaserClass CeaserClass;
        VigenereClass VigenereClass;
        VernamClass VernamClass;
        MagicSquareClass MagicSquareClass;
        PlayfairClass PlayfairClass;
        public Form1()
        {
            InitializeComponent();
            CeaserClass = new CeaserClass();
            VigenereClass = new VigenereClass();
            VernamClass = new VernamClass();
            MagicSquareClass = new MagicSquareClass();
            PlayfairClass = new PlayfairClass();
            CeaserAlphabetLabel.Text = CeaserClass.Alphabet.ConvertAlphabet();
        }

        #region Ceaser

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {
            int key;
            if (!int.TryParse(ceaserKeyTextBox.Text, out key))
            {
                MessageBox.Show("Введите целое число!");
                return;
            }
            CeaserClass.Key = key;
            CeaserShiftedAlphabetLabel.Text = CeaserClass.ShiftedAlphabet.ConvertAlphabet();
        }

        private void CeaserEncryptButton_Click(object sender, EventArgs e)
        {
            if (CeaserPlainTextBox.Text.InputIsLocalValue())
                CeaserChipherTextBox.Text = CeaserClass.Encrypt(CeaserPlainTextBox.Text);
            else
                MessageBox.Show("Не принимает другие локализации. \nИспользуйте только русский алфавит!");
        }

        private void CeaserDecryptButton_Click(object sender, EventArgs e)
        {
            if (CeaserPlainTextBox.Text.InputIsLocalValue())
                CeaserChipherTextBox.Text = CeaserClass.Decrypt(CeaserPlainTextBox.Text);
            else
                MessageBox.Show("Не принимает другие локализации. \nИспользуйте только русский алфавит!");
        }

        private void CeaserSwapTextButton_Click(object sender, EventArgs e)
        {
            CeaserPlainTextBox.Text = CeaserChipherTextBox.Text;
            CeaserChipherTextBox.Text = "";
        }
        #endregion

        #region Vigenere

        private void VigenereEncryptButton_Click(object sender, EventArgs e)
        {
            string key = VigenereKeyTextBox.Text;
            if (key.InputIsLocalValue() && VigenerePlainTextBox.Text.InputIsLocalValue())
            {
                VigenereClass.Key = key;
                VigenereCipherTextBox.Text = VigenereClass.Encrypt(VigenerePlainTextBox.Text);
            }
            else
                MessageBox.Show("Не принимает другие локализации. \nИспользуйте только русский алфавит!");
        }

        private void VigenereDecryptButton_Click(object sender, EventArgs e)
        {
            string key = VigenereKeyTextBox.Text;
            if (key.InputIsLocalValue() && VigenerePlainTextBox.Text.InputIsLocalValue())
            {
                VigenereClass.Key = key;
                VigenereCipherTextBox.Text = VigenereClass.Decrypt(VigenerePlainTextBox.Text);
            }
            else
                MessageBox.Show("Не принимает другие локализации. \nИспользуйте только русский алфавит!");
        }

        private void VigenereSwapTextButton_Click(object sender, EventArgs e)
        {
            VigenerePlainTextBox.Text = VigenereCipherTextBox.Text;
            VigenereCipherTextBox.Text = "";
        }

        private void VigenereShowTableButton_Click(object sender, EventArgs e)
        {
            VigenereTable vigenereTable = new VigenereTable();
            vigenereTable.Show();
        }
        #endregion

        #region Vernam

        private void VernamEncryptButton_Click(object sender, EventArgs e)
        {
            if (VernamKeyTextBox.Text.InputIsLocalValue() && VernamPlainTextBox.Text.InputIsLocalValue())
            {
                VernamClass.Key = VernamKeyTextBox.Text;
                if (VernamPlainTextBox.Text.Length == VernamClass.Key.Length)
                    VernamCipherTextBox.Text = VernamClass.Encrypt(VernamPlainTextBox.Text);
                else
                    MessageBox.Show("Длина ключа и текста должна быть одинаковой!");
            }
            else
                MessageBox.Show("Не принимает другие локализации. \nИспользуйте только русский алфавит!");
        }

        private void VernamDecyptButton_Click(object sender, EventArgs e)
        {
            if (VernamKeyTextBox.Text.InputIsLocalValue() && VernamPlainTextBox.Text.InputIsLocalValue())
            {
                VernamClass.Key = VernamKeyTextBox.Text;
                if (VernamPlainTextBox.Text.Length == VernamClass.Key.Length)
                    VernamCipherTextBox.Text = VernamClass.Decrypt(VernamPlainTextBox.Text);
                else
                    MessageBox.Show("Длина ключа и текста должна быть одинаковой!");
            }
            else
                MessageBox.Show("Не принимает другие локализации. \nИспользуйте только русский алфавит!");
        }

        private void VernamSwapTextButton_Click(object sender, EventArgs e)
        {
            VernamPlainTextBox.Text = VernamCipherTextBox.Text;
            VernamCipherTextBox.Text = "";
        }

        #endregion

        #region Playfair

        private void PlayfairGenerateTable_Click(object sender, EventArgs e)
        {
            PlayfairClass.Key = PlayfairkeyTextBox.Text;
            if (PlayfairClass.Key.InputIsLocalValue())
            {
                string table = PlayfairClass.GenerateTable();
                dataGridView3.Rows.Clear();
                dataGridView3.Refresh();

                int height = 4;
                int width = 8;

                dataGridView3.ColumnCount = width;
                for (int r = 0; r < height; r++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView3);

                    for (int c = 0; c < width; c++)
                    {
                        
                        row.Cells[c].Value = table[r*width+c];
                        dataGridView3.Columns[c].Width = 30;

                    }
                    dataGridView3.Rows.Add(row);
                    //row.Height = dataGridView3.Height / height;
                }
                dataGridView3.AllowUserToAddRows = false;
            }
            else
                MessageBox.Show("Ключевое слово не может содержать символы, которых нет в алфавите!");
        }

        #endregion

        #region MagicSquare

        private void MagicEncryptButton_Click(object sender, EventArgs e)
        {
            int tt = (int)Math.Sqrt(MagicPlainTextBox.Text.Length);
            if (tt * tt == MagicPlainTextBox.Text.Length)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();

                MagicEncryptTextBox.Text = MagicSquareClass.Encrypt(MagicPlainTextBox.Text);
                int height = MagicSquareClass.FillRandomNumberMatrix.GetLength(0);
                int width = MagicSquareClass.FillRandomNumberMatrix.GetLength(1);

                dataGridView1.ColumnCount = width;
                for (int r = 0; r < height; r++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);

                    for (int c = 0; c < width; c++)
                    {
                        dataGridView1.Columns[c].Width = dataGridView1.Width / height;
                        row.Cells[c].Value = MagicSquareClass.FillRandomNumberMatrix[r, c];
                    }
                    dataGridView1.Rows.Add(row);
                    row.Height = dataGridView1.Width / height;
                }
                dataGridView1.AllowUserToAddRows = false;


                dataGridView2.ColumnCount = width;
                for (int r = 0; r < height; r++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView2);

                    for (int c = 0; c < width; c++)
                    {
                        dataGridView2.Columns[c].Width = dataGridView2.Width / height;
                        row.Cells[c].Value = MagicEncryptTextBox.Text[r * width + c];
                    }
                    dataGridView2.Rows.Add(row);
                    row.Height = dataGridView2.Width / height;
                }
                dataGridView2.AllowUserToAddRows = false;
            }
            else
                MessageBox.Show("Длина текста должна быть квадратной.");
        }

        private void MagicDecryptButton_Click(object sender, EventArgs e)
        {
            MagicDecryptTextBox.Text = MagicSquareClass.Decrypt(MagicEncryptTextBox.Text);
        }


        #endregion

        private void PlayfairSwapTextButton_Click(object sender, EventArgs e)
        {
            PlayfairPlainTextBox.Text = PlayfairCipherTextBox.Text;
            PlayfairCipherTextBox.Text = "";
        }

        private void PlayfairEncryptButton_Click(object sender, EventArgs e)
        {
            if (PlayfairClass.Key.InputIsLocalValue())
            {
                PlayfairBigrammaTextBox.Text = PlayfairClass.GenerateBigramma(PlayfairPlainTextBox.Text);
                PlayfairCipherTextBox.Text = PlayfairClass.Encrypt(PlayfairPlainTextBox.Text);
            }
            else
                MessageBox.Show("Ключевое слово не может содержать символы, которых нет в алфавите!");
        }
    }
}
