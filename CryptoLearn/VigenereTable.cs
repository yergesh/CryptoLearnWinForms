using CryptoLearn.Helper;
using CryptoLearn.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoLearn
{
    public partial class VigenereTable : Form
    {
        
		VigenereClass VigenereClass;
		public VigenereTable()
        {
            InitializeComponent();
            VigenereClass = new VigenereClass();
			for (int i = 0; i < VigenereClass.ShiftedAlphabet.Count; i++)
            {
				dataGridView1.Rows.Add(VigenereClass.ShiftedAlphabet[i].ConvertAlphabetTab());
            }
        }
    }
}
