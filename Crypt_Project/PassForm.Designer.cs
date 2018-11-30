namespace Crypt_Project
{
    partial class PassForm
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
            this.checkPassButton = new System.Windows.Forms.Button();
            this.textPassBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkPassButton
            // 
            this.checkPassButton.Location = new System.Drawing.Point(117, 72);
            this.checkPassButton.Name = "checkPassButton";
            this.checkPassButton.Size = new System.Drawing.Size(143, 35);
            this.checkPassButton.TabIndex = 0;
            this.checkPassButton.Text = "Перевірити";
            this.checkPassButton.UseVisualStyleBackColor = true;
            this.checkPassButton.Click += new System.EventHandler(this.checkPassButton_Click);
            // 
            // textPassBox
            // 
            this.textPassBox.Location = new System.Drawing.Point(42, 37);
            this.textPassBox.Name = "textPassBox";
            this.textPassBox.PasswordChar = '*';
            this.textPassBox.Size = new System.Drawing.Size(311, 20);
            this.textPassBox.TabIndex = 1;
            // 
            // PassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 129);
            this.Controls.Add(this.textPassBox);
            this.Controls.Add(this.checkPassButton);
            this.Name = "PassForm";
            this.Text = "PassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkPassButton;
        private System.Windows.Forms.TextBox textPassBox;
    }
}