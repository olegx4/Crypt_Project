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
            this.SuspendLayout();
            // 
            // textLine
            // 
            this.textLine.Location = new System.Drawing.Point(25, 49);
            this.textLine.Name = "textLine";
            this.textLine.Size = new System.Drawing.Size(447, 20);
            this.textLine.TabIndex = 0;
            this.textLine.Text = "Введіть, будь ласка, ваш текст ";
            // 
            // encrypt
            // 
            this.encrypt.BackColor = System.Drawing.SystemColors.Control;
            this.encrypt.Location = new System.Drawing.Point(25, 175);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(102, 33);
            this.encrypt.TabIndex = 1;
            this.encrypt.Text = "Зашифрувати";
            this.encrypt.UseVisualStyleBackColor = false;
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(152, 175);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(102, 33);
            this.Decrypt.TabIndex = 2;
            this.Decrypt.Text = "Розшифрувати";
            this.Decrypt.UseVisualStyleBackColor = true;
            // 
            // enCryptText
            // 
            this.enCryptText.Location = new System.Drawing.Point(25, 86);
            this.enCryptText.Name = "enCryptText";
            this.enCryptText.Size = new System.Drawing.Size(447, 20);
            this.enCryptText.TabIndex = 3;
            // 
            // deCryptText
            // 
            this.deCryptText.Location = new System.Drawing.Point(25, 124);
            this.deCryptText.Name = "deCryptText";
            this.deCryptText.Size = new System.Drawing.Size(447, 20);
            this.deCryptText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 360);
            this.Controls.Add(this.deCryptText);
            this.Controls.Add(this.enCryptText);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.textLine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLine;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox enCryptText;
        private System.Windows.Forms.TextBox deCryptText;
    }
}

