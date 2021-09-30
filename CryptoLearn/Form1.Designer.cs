namespace CryptoLearn
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ceaserTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CeaserDecryptButton = new System.Windows.Forms.Button();
            this.CeaserEncryptButton = new System.Windows.Forms.Button();
            this.CeaserSwapTextButton = new System.Windows.Forms.Button();
            this.CeaserChipherTextBox = new System.Windows.Forms.RichTextBox();
            this.CeaserPlainTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CeaserShiftedAlphabetLabel = new System.Windows.Forms.Label();
            this.CeaserAlphabetLabel = new System.Windows.Forms.Label();
            this.ceaserKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vigenereTabPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.VigenereDecryptButton = new System.Windows.Forms.Button();
            this.VigenereEncryptButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.VigenereCipherTextBox = new System.Windows.Forms.RichTextBox();
            this.VigenerePlainTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.VigenereShowTableButton = new System.Windows.Forms.Button();
            this.VigenereKeyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vernamTabPage = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playfairTabPage = new System.Windows.Forms.TabPage();
            this.magicSquareTabPage = new System.Windows.Forms.TabPage();
            this.VernamKeyTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.VernamDecyptButton = new System.Windows.Forms.Button();
            this.VernamEncryptButton = new System.Windows.Forms.Button();
            this.VernamSwapTextButton = new System.Windows.Forms.Button();
            this.VernamCipherTextBox = new System.Windows.Forms.RichTextBox();
            this.VernamPlainTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.MagicPlainTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MagicEncryptTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MagicDecryptTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MagicEncryptButton = new System.Windows.Forms.Button();
            this.MagicDecryptButton = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.PlayfairDecryptButton = new System.Windows.Forms.Button();
            this.PlayfairEncryptButton = new System.Windows.Forms.Button();
            this.PlayfairSwapTextButton = new System.Windows.Forms.Button();
            this.PlayfairCipherTextBox = new System.Windows.Forms.RichTextBox();
            this.PlayfairPlainTextBox = new System.Windows.Forms.RichTextBox();
            this.PlayfairBigrammaTextBox = new System.Windows.Forms.RichTextBox();
            this.PlayfairGenerateTable = new System.Windows.Forms.Button();
            this.PlayfairkeyTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.ceaserTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.vigenereTabPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.vernamTabPage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.playfairTabPage.SuspendLayout();
            this.magicSquareTabPage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ceaserTabPage);
            this.tabControl1.Controls.Add(this.vigenereTabPage);
            this.tabControl1.Controls.Add(this.vernamTabPage);
            this.tabControl1.Controls.Add(this.playfairTabPage);
            this.tabControl1.Controls.Add(this.magicSquareTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // ceaserTabPage
            // 
            this.ceaserTabPage.Controls.Add(this.groupBox2);
            this.ceaserTabPage.Controls.Add(this.groupBox1);
            this.ceaserTabPage.Location = new System.Drawing.Point(4, 22);
            this.ceaserTabPage.Name = "ceaserTabPage";
            this.ceaserTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ceaserTabPage.Size = new System.Drawing.Size(792, 424);
            this.ceaserTabPage.TabIndex = 0;
            this.ceaserTabPage.Text = "Цезарь";
            this.ceaserTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CeaserDecryptButton);
            this.groupBox2.Controls.Add(this.CeaserEncryptButton);
            this.groupBox2.Controls.Add(this.CeaserSwapTextButton);
            this.groupBox2.Controls.Add(this.CeaserChipherTextBox);
            this.groupBox2.Controls.Add(this.CeaserPlainTextBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 271);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Процесс";
            // 
            // CeaserDecryptButton
            // 
            this.CeaserDecryptButton.Location = new System.Drawing.Point(352, 159);
            this.CeaserDecryptButton.Name = "CeaserDecryptButton";
            this.CeaserDecryptButton.Size = new System.Drawing.Size(75, 23);
            this.CeaserDecryptButton.TabIndex = 4;
            this.CeaserDecryptButton.Text = "Decrypt";
            this.CeaserDecryptButton.UseVisualStyleBackColor = true;
            this.CeaserDecryptButton.Click += new System.EventHandler(this.CeaserDecryptButton_Click);
            // 
            // CeaserEncryptButton
            // 
            this.CeaserEncryptButton.Location = new System.Drawing.Point(352, 130);
            this.CeaserEncryptButton.Name = "CeaserEncryptButton";
            this.CeaserEncryptButton.Size = new System.Drawing.Size(75, 23);
            this.CeaserEncryptButton.TabIndex = 3;
            this.CeaserEncryptButton.Text = "Encrypt";
            this.CeaserEncryptButton.UseVisualStyleBackColor = true;
            this.CeaserEncryptButton.Click += new System.EventHandler(this.CeaserEncryptButton_Click);
            // 
            // CeaserSwapTextButton
            // 
            this.CeaserSwapTextButton.Location = new System.Drawing.Point(352, 101);
            this.CeaserSwapTextButton.Name = "CeaserSwapTextButton";
            this.CeaserSwapTextButton.Size = new System.Drawing.Size(75, 23);
            this.CeaserSwapTextButton.TabIndex = 2;
            this.CeaserSwapTextButton.Text = "Swap";
            this.CeaserSwapTextButton.UseVisualStyleBackColor = true;
            this.CeaserSwapTextButton.Click += new System.EventHandler(this.CeaserSwapTextButton_Click);
            // 
            // CeaserChipherTextBox
            // 
            this.CeaserChipherTextBox.Location = new System.Drawing.Point(445, 19);
            this.CeaserChipherTextBox.Name = "CeaserChipherTextBox";
            this.CeaserChipherTextBox.Size = new System.Drawing.Size(325, 246);
            this.CeaserChipherTextBox.TabIndex = 1;
            this.CeaserChipherTextBox.Text = "";
            // 
            // CeaserPlainTextBox
            // 
            this.CeaserPlainTextBox.Location = new System.Drawing.Point(6, 19);
            this.CeaserPlainTextBox.Name = "CeaserPlainTextBox";
            this.CeaserPlainTextBox.Size = new System.Drawing.Size(325, 246);
            this.CeaserPlainTextBox.TabIndex = 0;
            this.CeaserPlainTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CeaserShiftedAlphabetLabel);
            this.groupBox1.Controls.Add(this.CeaserAlphabetLabel);
            this.groupBox1.Controls.Add(this.ceaserKeyTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инициализация";
            // 
            // CeaserShiftedAlphabetLabel
            // 
            this.CeaserShiftedAlphabetLabel.AutoSize = true;
            this.CeaserShiftedAlphabetLabel.Location = new System.Drawing.Point(208, 103);
            this.CeaserShiftedAlphabetLabel.Name = "CeaserShiftedAlphabetLabel";
            this.CeaserShiftedAlphabetLabel.Size = new System.Drawing.Size(0, 13);
            this.CeaserShiftedAlphabetLabel.TabIndex = 5;
            // 
            // CeaserAlphabetLabel
            // 
            this.CeaserAlphabetLabel.AutoSize = true;
            this.CeaserAlphabetLabel.Location = new System.Drawing.Point(208, 73);
            this.CeaserAlphabetLabel.Name = "CeaserAlphabetLabel";
            this.CeaserAlphabetLabel.Size = new System.Drawing.Size(0, 13);
            this.CeaserAlphabetLabel.TabIndex = 4;
            // 
            // ceaserKeyTextBox
            // 
            this.ceaserKeyTextBox.Location = new System.Drawing.Point(47, 25);
            this.ceaserKeyTextBox.Name = "ceaserKeyTextBox";
            this.ceaserKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.ceaserKeyTextBox.TabIndex = 3;
            this.ceaserKeyTextBox.TextChanged += new System.EventHandler(this.keyTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ключ";
            // 
            // vigenereTabPage
            // 
            this.vigenereTabPage.Controls.Add(this.groupBox4);
            this.vigenereTabPage.Controls.Add(this.groupBox3);
            this.vigenereTabPage.Location = new System.Drawing.Point(4, 22);
            this.vigenereTabPage.Name = "vigenereTabPage";
            this.vigenereTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.vigenereTabPage.Size = new System.Drawing.Size(792, 424);
            this.vigenereTabPage.TabIndex = 1;
            this.vigenereTabPage.Text = "Вижинер";
            this.vigenereTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.VigenereDecryptButton);
            this.groupBox4.Controls.Add(this.VigenereEncryptButton);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.VigenereCipherTextBox);
            this.groupBox4.Controls.Add(this.VigenerePlainTextBox);
            this.groupBox4.Location = new System.Drawing.Point(8, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 271);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Процесс";
            // 
            // VigenereDecryptButton
            // 
            this.VigenereDecryptButton.Location = new System.Drawing.Point(352, 159);
            this.VigenereDecryptButton.Name = "VigenereDecryptButton";
            this.VigenereDecryptButton.Size = new System.Drawing.Size(75, 23);
            this.VigenereDecryptButton.TabIndex = 4;
            this.VigenereDecryptButton.Text = "Decrypt";
            this.VigenereDecryptButton.UseVisualStyleBackColor = true;
            this.VigenereDecryptButton.Click += new System.EventHandler(this.VigenereDecryptButton_Click);
            // 
            // VigenereEncryptButton
            // 
            this.VigenereEncryptButton.Location = new System.Drawing.Point(352, 130);
            this.VigenereEncryptButton.Name = "VigenereEncryptButton";
            this.VigenereEncryptButton.Size = new System.Drawing.Size(75, 23);
            this.VigenereEncryptButton.TabIndex = 3;
            this.VigenereEncryptButton.Text = "Encrypt";
            this.VigenereEncryptButton.UseVisualStyleBackColor = true;
            this.VigenereEncryptButton.Click += new System.EventHandler(this.VigenereEncryptButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Swap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.VigenereSwapTextButton_Click);
            // 
            // VigenereCipherTextBox
            // 
            this.VigenereCipherTextBox.Location = new System.Drawing.Point(445, 19);
            this.VigenereCipherTextBox.Name = "VigenereCipherTextBox";
            this.VigenereCipherTextBox.Size = new System.Drawing.Size(325, 246);
            this.VigenereCipherTextBox.TabIndex = 1;
            this.VigenereCipherTextBox.Text = "";
            // 
            // VigenerePlainTextBox
            // 
            this.VigenerePlainTextBox.Location = new System.Drawing.Point(6, 19);
            this.VigenerePlainTextBox.Name = "VigenerePlainTextBox";
            this.VigenerePlainTextBox.Size = new System.Drawing.Size(325, 246);
            this.VigenerePlainTextBox.TabIndex = 0;
            this.VigenerePlainTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VigenereShowTableButton);
            this.groupBox3.Controls.Add(this.VigenereKeyTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 135);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Инициализация";
            // 
            // VigenereShowTableButton
            // 
            this.VigenereShowTableButton.Location = new System.Drawing.Point(9, 60);
            this.VigenereShowTableButton.Name = "VigenereShowTableButton";
            this.VigenereShowTableButton.Size = new System.Drawing.Size(138, 38);
            this.VigenereShowTableButton.TabIndex = 4;
            this.VigenereShowTableButton.Text = "См. таблицу";
            this.VigenereShowTableButton.UseVisualStyleBackColor = true;
            this.VigenereShowTableButton.Click += new System.EventHandler(this.VigenereShowTableButton_Click);
            // 
            // VigenereKeyTextBox
            // 
            this.VigenereKeyTextBox.Location = new System.Drawing.Point(47, 25);
            this.VigenereKeyTextBox.Name = "VigenereKeyTextBox";
            this.VigenereKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.VigenereKeyTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ключ";
            // 
            // vernamTabPage
            // 
            this.vernamTabPage.Controls.Add(this.groupBox6);
            this.vernamTabPage.Controls.Add(this.groupBox5);
            this.vernamTabPage.Location = new System.Drawing.Point(4, 22);
            this.vernamTabPage.Name = "vernamTabPage";
            this.vernamTabPage.Size = new System.Drawing.Size(792, 424);
            this.vernamTabPage.TabIndex = 2;
            this.vernamTabPage.Text = "Вернам";
            this.vernamTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.VernamKeyTextBox);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(8, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(776, 135);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Инициализация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ключ";
            // 
            // playfairTabPage
            // 
            this.playfairTabPage.Controls.Add(this.groupBox10);
            this.playfairTabPage.Controls.Add(this.groupBox9);
            this.playfairTabPage.Location = new System.Drawing.Point(4, 22);
            this.playfairTabPage.Name = "playfairTabPage";
            this.playfairTabPage.Size = new System.Drawing.Size(792, 424);
            this.playfairTabPage.TabIndex = 3;
            this.playfairTabPage.Text = "Плейфер";
            this.playfairTabPage.UseVisualStyleBackColor = true;
            // 
            // magicSquareTabPage
            // 
            this.magicSquareTabPage.Controls.Add(this.groupBox8);
            this.magicSquareTabPage.Controls.Add(this.groupBox7);
            this.magicSquareTabPage.Location = new System.Drawing.Point(4, 22);
            this.magicSquareTabPage.Name = "magicSquareTabPage";
            this.magicSquareTabPage.Size = new System.Drawing.Size(792, 424);
            this.magicSquareTabPage.TabIndex = 4;
            this.magicSquareTabPage.Text = "Магический квадрат";
            this.magicSquareTabPage.UseVisualStyleBackColor = true;
            // 
            // VernamKeyTextBox
            // 
            this.VernamKeyTextBox.Location = new System.Drawing.Point(45, 25);
            this.VernamKeyTextBox.Name = "VernamKeyTextBox";
            this.VernamKeyTextBox.Size = new System.Drawing.Size(296, 96);
            this.VernamKeyTextBox.TabIndex = 4;
            this.VernamKeyTextBox.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.VernamDecyptButton);
            this.groupBox6.Controls.Add(this.VernamEncryptButton);
            this.groupBox6.Controls.Add(this.VernamSwapTextButton);
            this.groupBox6.Controls.Add(this.VernamCipherTextBox);
            this.groupBox6.Controls.Add(this.VernamPlainTextBox);
            this.groupBox6.Location = new System.Drawing.Point(8, 147);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(776, 271);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Процесс";
            // 
            // VernamDecyptButton
            // 
            this.VernamDecyptButton.Location = new System.Drawing.Point(352, 159);
            this.VernamDecyptButton.Name = "VernamDecyptButton";
            this.VernamDecyptButton.Size = new System.Drawing.Size(75, 23);
            this.VernamDecyptButton.TabIndex = 4;
            this.VernamDecyptButton.Text = "Decrypt";
            this.VernamDecyptButton.UseVisualStyleBackColor = true;
            this.VernamDecyptButton.Click += new System.EventHandler(this.VernamDecyptButton_Click);
            // 
            // VernamEncryptButton
            // 
            this.VernamEncryptButton.Location = new System.Drawing.Point(352, 130);
            this.VernamEncryptButton.Name = "VernamEncryptButton";
            this.VernamEncryptButton.Size = new System.Drawing.Size(75, 23);
            this.VernamEncryptButton.TabIndex = 3;
            this.VernamEncryptButton.Text = "Encrypt";
            this.VernamEncryptButton.UseVisualStyleBackColor = true;
            this.VernamEncryptButton.Click += new System.EventHandler(this.VernamEncryptButton_Click);
            // 
            // VernamSwapTextButton
            // 
            this.VernamSwapTextButton.Location = new System.Drawing.Point(352, 101);
            this.VernamSwapTextButton.Name = "VernamSwapTextButton";
            this.VernamSwapTextButton.Size = new System.Drawing.Size(75, 23);
            this.VernamSwapTextButton.TabIndex = 2;
            this.VernamSwapTextButton.Text = "Swap";
            this.VernamSwapTextButton.UseVisualStyleBackColor = true;
            this.VernamSwapTextButton.Click += new System.EventHandler(this.VernamSwapTextButton_Click);
            // 
            // VernamCipherTextBox
            // 
            this.VernamCipherTextBox.Location = new System.Drawing.Point(445, 19);
            this.VernamCipherTextBox.Name = "VernamCipherTextBox";
            this.VernamCipherTextBox.Size = new System.Drawing.Size(325, 246);
            this.VernamCipherTextBox.TabIndex = 1;
            this.VernamCipherTextBox.Text = "";
            // 
            // VernamPlainTextBox
            // 
            this.VernamPlainTextBox.Location = new System.Drawing.Point(6, 19);
            this.VernamPlainTextBox.Name = "VernamPlainTextBox";
            this.VernamPlainTextBox.Size = new System.Drawing.Size(325, 246);
            this.VernamPlainTextBox.TabIndex = 0;
            this.VernamPlainTextBox.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.MagicDecryptButton);
            this.groupBox7.Controls.Add(this.MagicEncryptButton);
            this.groupBox7.Controls.Add(this.MagicDecryptTextBox);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.MagicEncryptTextBox);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.MagicPlainTextBox);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Location = new System.Drawing.Point(8, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(313, 410);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Инициализация";
            // 
            // MagicPlainTextBox
            // 
            this.MagicPlainTextBox.Location = new System.Drawing.Point(6, 44);
            this.MagicPlainTextBox.Name = "MagicPlainTextBox";
            this.MagicPlainTextBox.Size = new System.Drawing.Size(296, 20);
            this.MagicPlainTextBox.TabIndex = 4;
            this.MagicPlainTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Исходный текст";
            // 
            // MagicEncryptTextBox
            // 
            this.MagicEncryptTextBox.Location = new System.Drawing.Point(6, 88);
            this.MagicEncryptTextBox.Name = "MagicEncryptTextBox";
            this.MagicEncryptTextBox.Size = new System.Drawing.Size(296, 20);
            this.MagicEncryptTextBox.TabIndex = 6;
            this.MagicEncryptTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Зашифрованный текст";
            // 
            // MagicDecryptTextBox
            // 
            this.MagicDecryptTextBox.Location = new System.Drawing.Point(6, 136);
            this.MagicDecryptTextBox.Name = "MagicDecryptTextBox";
            this.MagicDecryptTextBox.Size = new System.Drawing.Size(296, 20);
            this.MagicDecryptTextBox.TabIndex = 8;
            this.MagicDecryptTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дешифрованный текст";
            // 
            // MagicEncryptButton
            // 
            this.MagicEncryptButton.Location = new System.Drawing.Point(43, 177);
            this.MagicEncryptButton.Name = "MagicEncryptButton";
            this.MagicEncryptButton.Size = new System.Drawing.Size(217, 23);
            this.MagicEncryptButton.TabIndex = 9;
            this.MagicEncryptButton.Text = "Encrypt";
            this.MagicEncryptButton.UseVisualStyleBackColor = true;
            this.MagicEncryptButton.Click += new System.EventHandler(this.MagicEncryptButton_Click);
            // 
            // MagicDecryptButton
            // 
            this.MagicDecryptButton.Location = new System.Drawing.Point(43, 219);
            this.MagicDecryptButton.Name = "MagicDecryptButton";
            this.MagicDecryptButton.Size = new System.Drawing.Size(217, 23);
            this.MagicDecryptButton.TabIndex = 10;
            this.MagicDecryptButton.Text = "Decrypt";
            this.MagicDecryptButton.UseVisualStyleBackColor = true;
            this.MagicDecryptButton.Click += new System.EventHandler(this.MagicDecryptButton_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dataGridView2);
            this.groupBox8.Controls.Add(this.dataGridView1);
            this.groupBox8.Location = new System.Drawing.Point(328, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(456, 410);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Процесс";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(220, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(230, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(220, 220);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.PlayfairkeyTextBox);
            this.groupBox9.Controls.Add(this.PlayfairGenerateTable);
            this.groupBox9.Controls.Add(this.dataGridView3);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Location = new System.Drawing.Point(8, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(776, 135);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Инициализация";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ключ";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Location = new System.Drawing.Point(327, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 20;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView3.Size = new System.Drawing.Size(240, 100);
            this.dataGridView3.TabIndex = 5;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.PlayfairBigrammaTextBox);
            this.groupBox10.Controls.Add(this.PlayfairDecryptButton);
            this.groupBox10.Controls.Add(this.PlayfairEncryptButton);
            this.groupBox10.Controls.Add(this.PlayfairSwapTextButton);
            this.groupBox10.Controls.Add(this.PlayfairCipherTextBox);
            this.groupBox10.Controls.Add(this.PlayfairPlainTextBox);
            this.groupBox10.Location = new System.Drawing.Point(8, 147);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(776, 271);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Процесс";
            // 
            // PlayfairDecryptButton
            // 
            this.PlayfairDecryptButton.Location = new System.Drawing.Point(429, 167);
            this.PlayfairDecryptButton.Name = "PlayfairDecryptButton";
            this.PlayfairDecryptButton.Size = new System.Drawing.Size(75, 23);
            this.PlayfairDecryptButton.TabIndex = 4;
            this.PlayfairDecryptButton.Text = "Decrypt";
            this.PlayfairDecryptButton.UseVisualStyleBackColor = true;
            this.PlayfairDecryptButton.Click += new System.EventHandler(this.PlayfairEncryptButton_Click);
            // 
            // PlayfairEncryptButton
            // 
            this.PlayfairEncryptButton.Location = new System.Drawing.Point(429, 138);
            this.PlayfairEncryptButton.Name = "PlayfairEncryptButton";
            this.PlayfairEncryptButton.Size = new System.Drawing.Size(75, 23);
            this.PlayfairEncryptButton.TabIndex = 3;
            this.PlayfairEncryptButton.Text = "Encrypt";
            this.PlayfairEncryptButton.UseVisualStyleBackColor = true;
            this.PlayfairEncryptButton.Click += new System.EventHandler(this.PlayfairEncryptButton_Click);
            // 
            // PlayfairSwapTextButton
            // 
            this.PlayfairSwapTextButton.Location = new System.Drawing.Point(429, 109);
            this.PlayfairSwapTextButton.Name = "PlayfairSwapTextButton";
            this.PlayfairSwapTextButton.Size = new System.Drawing.Size(75, 23);
            this.PlayfairSwapTextButton.TabIndex = 2;
            this.PlayfairSwapTextButton.Text = "Swap";
            this.PlayfairSwapTextButton.UseVisualStyleBackColor = true;
            this.PlayfairSwapTextButton.Click += new System.EventHandler(this.PlayfairSwapTextButton_Click);
            // 
            // PlayfairCipherTextBox
            // 
            this.PlayfairCipherTextBox.Location = new System.Drawing.Point(510, 19);
            this.PlayfairCipherTextBox.Name = "PlayfairCipherTextBox";
            this.PlayfairCipherTextBox.Size = new System.Drawing.Size(260, 246);
            this.PlayfairCipherTextBox.TabIndex = 1;
            this.PlayfairCipherTextBox.Text = "";
            // 
            // PlayfairPlainTextBox
            // 
            this.PlayfairPlainTextBox.Location = new System.Drawing.Point(6, 19);
            this.PlayfairPlainTextBox.Name = "PlayfairPlainTextBox";
            this.PlayfairPlainTextBox.Size = new System.Drawing.Size(202, 246);
            this.PlayfairPlainTextBox.TabIndex = 0;
            this.PlayfairPlainTextBox.Text = "";
            // 
            // PlayfairBigrammaTextBox
            // 
            this.PlayfairBigrammaTextBox.Location = new System.Drawing.Point(214, 19);
            this.PlayfairBigrammaTextBox.Name = "PlayfairBigrammaTextBox";
            this.PlayfairBigrammaTextBox.Size = new System.Drawing.Size(209, 246);
            this.PlayfairBigrammaTextBox.TabIndex = 5;
            this.PlayfairBigrammaTextBox.Text = "";
            // 
            // PlayfairGenerateTable
            // 
            this.PlayfairGenerateTable.Location = new System.Drawing.Point(9, 94);
            this.PlayfairGenerateTable.Name = "PlayfairGenerateTable";
            this.PlayfairGenerateTable.Size = new System.Drawing.Size(121, 23);
            this.PlayfairGenerateTable.TabIndex = 6;
            this.PlayfairGenerateTable.Text = "Генарация таблицы";
            this.PlayfairGenerateTable.UseVisualStyleBackColor = true;
            this.PlayfairGenerateTable.Click += new System.EventHandler(this.PlayfairGenerateTable_Click);
            // 
            // PlayfairkeyTextBox
            // 
            this.PlayfairkeyTextBox.Location = new System.Drawing.Point(45, 25);
            this.PlayfairkeyTextBox.Name = "PlayfairkeyTextBox";
            this.PlayfairkeyTextBox.Size = new System.Drawing.Size(233, 20);
            this.PlayfairkeyTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CryptoLearn";
            this.tabControl1.ResumeLayout(false);
            this.ceaserTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.vigenereTabPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.vernamTabPage.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.playfairTabPage.ResumeLayout(false);
            this.magicSquareTabPage.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ceaserTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage vigenereTabPage;
        private System.Windows.Forms.TabPage vernamTabPage;
        private System.Windows.Forms.TabPage playfairTabPage;
        private System.Windows.Forms.TabPage magicSquareTabPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CeaserEncryptButton;
        private System.Windows.Forms.Button CeaserSwapTextButton;
        private System.Windows.Forms.RichTextBox CeaserChipherTextBox;
        private System.Windows.Forms.RichTextBox CeaserPlainTextBox;
        private System.Windows.Forms.TextBox ceaserKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CeaserShiftedAlphabetLabel;
        private System.Windows.Forms.Label CeaserAlphabetLabel;
        private System.Windows.Forms.Button CeaserDecryptButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button VigenereDecryptButton;
        private System.Windows.Forms.Button VigenereEncryptButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox VigenereCipherTextBox;
        private System.Windows.Forms.RichTextBox VigenerePlainTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox VigenereKeyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button VigenereShowTableButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button VernamDecyptButton;
        private System.Windows.Forms.Button VernamEncryptButton;
        private System.Windows.Forms.Button VernamSwapTextButton;
        private System.Windows.Forms.RichTextBox VernamCipherTextBox;
        private System.Windows.Forms.RichTextBox VernamPlainTextBox;
        private System.Windows.Forms.RichTextBox VernamKeyTextBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button MagicDecryptButton;
        private System.Windows.Forms.Button MagicEncryptButton;
        private System.Windows.Forms.RichTextBox MagicDecryptTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox MagicEncryptTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox MagicPlainTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RichTextBox PlayfairBigrammaTextBox;
        private System.Windows.Forms.Button PlayfairDecryptButton;
        private System.Windows.Forms.Button PlayfairEncryptButton;
        private System.Windows.Forms.Button PlayfairSwapTextButton;
        private System.Windows.Forms.RichTextBox PlayfairCipherTextBox;
        private System.Windows.Forms.RichTextBox PlayfairPlainTextBox;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PlayfairkeyTextBox;
        private System.Windows.Forms.Button PlayfairGenerateTable;
    }
}

