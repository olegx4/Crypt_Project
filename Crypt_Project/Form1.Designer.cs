namespace Crypt_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textLine = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.enCryptText = new System.Windows.Forms.TextBox();
            this.deCryptText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stepEnCrypt = new System.Windows.Forms.Button();
            this.label_inputText = new System.Windows.Forms.Label();
            this.label_encryptText = new System.Windows.Forms.Label();
            this.label_decryptText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cryptCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textLine
            // 
            this.textLine.Location = new System.Drawing.Point(24, 44);
            this.textLine.Multiline = true;
            this.textLine.Name = "textLine";
            this.textLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLine.Size = new System.Drawing.Size(498, 49);
            this.textLine.TabIndex = 0;
            this.textLine.Text = "маг";
            this.textLine.TextChanged += new System.EventHandler(this.textLine_TextChanged);
            // 
            // encrypt
            // 
            this.encrypt.BackColor = System.Drawing.SystemColors.Control;
            this.encrypt.Location = new System.Drawing.Point(25, 274);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(102, 33);
            this.encrypt.TabIndex = 1;
            this.encrypt.Text = "Зашифрувати";
            this.encrypt.UseVisualStyleBackColor = false;
            this.encrypt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.encrypt_MouseClick);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(152, 274);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(102, 33);
            this.Decrypt.TabIndex = 2;
            this.Decrypt.Text = "Розшифрувати";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // enCryptText
            // 
            this.enCryptText.Location = new System.Drawing.Point(24, 112);
            this.enCryptText.Multiline = true;
            this.enCryptText.Name = "enCryptText";
            this.enCryptText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.enCryptText.Size = new System.Drawing.Size(498, 59);
            this.enCryptText.TabIndex = 3;
            this.enCryptText.TextChanged += new System.EventHandler(this.enCryptText_TextChanged);
            // 
            // deCryptText
            // 
            this.deCryptText.Location = new System.Drawing.Point(25, 196);
            this.deCryptText.Multiline = true;
            this.deCryptText.Name = "deCryptText";
            this.deCryptText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deCryptText.Size = new System.Drawing.Size(497, 69);
            this.deCryptText.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 1000);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // stepEnCrypt
            // 
            this.stepEnCrypt.Location = new System.Drawing.Point(273, 274);
            this.stepEnCrypt.Name = "stepEnCrypt";
            this.stepEnCrypt.Size = new System.Drawing.Size(147, 33);
            this.stepEnCrypt.TabIndex = 6;
            this.stepEnCrypt.Text = "Покрокове шифрування";
            this.stepEnCrypt.UseVisualStyleBackColor = true;
            this.stepEnCrypt.Click += new System.EventHandler(this.stepEnCrypt_Click);
            // 
            // label_inputText
            // 
            this.label_inputText.AutoSize = true;
            this.label_inputText.Location = new System.Drawing.Point(28, 28);
            this.label_inputText.Name = "label_inputText";
            this.label_inputText.Size = new System.Drawing.Size(124, 13);
            this.label_inputText.TabIndex = 7;
            this.label_inputText.Text = "Текст для шифрування";
            // 
            // label_encryptText
            // 
            this.label_encryptText.AutoSize = true;
            this.label_encryptText.Location = new System.Drawing.Point(28, 96);
            this.label_encryptText.Name = "label_encryptText";
            this.label_encryptText.Size = new System.Drawing.Size(115, 13);
            this.label_encryptText.TabIndex = 8;
            this.label_encryptText.Text = "Зашифрований текст";
            // 
            // label_decryptText
            // 
            this.label_decryptText.AutoSize = true;
            this.label_decryptText.Location = new System.Drawing.Point(28, 180);
            this.label_decryptText.Name = "label_decryptText";
            this.label_decryptText.Size = new System.Drawing.Size(121, 13);
            this.label_decryptText.TabIndex = 9;
            this.label_decryptText.Text = "Розшифрований текст";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(25, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 317);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(25, 322);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(477, 69);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // cryptCodeTextBox
            // 
            this.cryptCodeTextBox.Location = new System.Drawing.Point(259, 18);
            this.cryptCodeTextBox.Name = "cryptCodeTextBox";
            this.cryptCodeTextBox.Size = new System.Drawing.Size(213, 20);
            this.cryptCodeTextBox.TabIndex = 12;
            this.cryptCodeTextBox.TextChanged += new System.EventHandler(this.cryptCodeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ключ для шифрування";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cryptCodeTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_decryptText);
            this.Controls.Add(this.label_encryptText);
            this.Controls.Add(this.label_inputText);
            this.Controls.Add(this.stepEnCrypt);
            this.Controls.Add(this.deCryptText);
            this.Controls.Add(this.enCryptText);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.textLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Шифр Гронсфельда";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLine;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox enCryptText;
        private System.Windows.Forms.TextBox deCryptText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button stepEnCrypt;
        private System.Windows.Forms.Label label_inputText;
        private System.Windows.Forms.Label label_encryptText;
        private System.Windows.Forms.Label label_decryptText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox cryptCodeTextBox;
        private System.Windows.Forms.Label label1;
    }
}

