namespace AsynkronDekryptering
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxExponent = new System.Windows.Forms.TextBox();
            this.textBoxModulus = new System.Windows.Forms.TextBox();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.buttonShowKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Modulus:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Exponent:";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(174, 249);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(112, 32);
            this.buttonDecrypt.TabIndex = 17;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click_1);
            // 
            // textBoxExponent
            // 
            this.textBoxExponent.Location = new System.Drawing.Point(97, 31);
            this.textBoxExponent.Name = "textBoxExponent";
            this.textBoxExponent.Size = new System.Drawing.Size(274, 20);
            this.textBoxExponent.TabIndex = 18;
            // 
            // textBoxModulus
            // 
            this.textBoxModulus.Location = new System.Drawing.Point(97, 68);
            this.textBoxModulus.Name = "textBoxModulus";
            this.textBoxModulus.Size = new System.Drawing.Size(274, 20);
            this.textBoxModulus.TabIndex = 19;
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Location = new System.Drawing.Point(97, 208);
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.Size = new System.Drawing.Size(274, 20);
            this.textBoxEncrypted.TabIndex = 20;
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Location = new System.Drawing.Point(97, 300);
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.Size = new System.Drawing.Size(274, 20);
            this.textBoxDecrypted.TabIndex = 21;
            // 
            // buttonShowKey
            // 
            this.buttonShowKey.Location = new System.Drawing.Point(174, 115);
            this.buttonShowKey.Name = "buttonShowKey";
            this.buttonShowKey.Size = new System.Drawing.Size(112, 32);
            this.buttonShowKey.TabIndex = 22;
            this.buttonShowKey.Text = "Show Key";
            this.buttonShowKey.UseVisualStyleBackColor = true;
            this.buttonShowKey.Click += new System.EventHandler(this.buttonShowKey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Encrypted:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Decrypted:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonShowKey);
            this.Controls.Add(this.textBoxDecrypted);
            this.Controls.Add(this.textBoxEncrypted);
            this.Controls.Add(this.textBoxModulus);
            this.Controls.Add(this.textBoxExponent);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RSAReceiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxExponent;
        private System.Windows.Forms.TextBox textBoxModulus;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.Button buttonShowKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

