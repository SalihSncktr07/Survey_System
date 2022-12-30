namespace Gelişmiş_Anket_Sistemi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAnket = new System.Windows.Forms.ComboBox();
            this.btnAnket = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnketAdd = new System.Windows.Forms.Button();
            this.btnSonucView = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anket Seçiniz :";
            // 
            // cbAnket
            // 
            this.cbAnket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnket.FormattingEnabled = true;
            this.cbAnket.Location = new System.Drawing.Point(96, 6);
            this.cbAnket.Name = "cbAnket";
            this.cbAnket.Size = new System.Drawing.Size(210, 25);
            this.cbAnket.TabIndex = 1;
            this.cbAnket.Click += new System.EventHandler(this.cbAnket_Click);
            // 
            // btnAnket
            // 
            this.btnAnket.Location = new System.Drawing.Point(96, 33);
            this.btnAnket.Name = "btnAnket";
            this.btnAnket.Size = new System.Drawing.Size(210, 25);
            this.btnAnket.TabIndex = 2;
            this.btnAnket.Text = "Anket\'e Git";
            this.btnAnket.UseVisualStyleBackColor = true;
            this.btnAnket.Click += new System.EventHandler(this.btnAnket_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNick);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAnketAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket Ekleme";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(84, 48);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(162, 24);
            this.txtPass.TabIndex = 12;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(84, 17);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(162, 24);
            this.txtNick.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // btnAnketAdd
            // 
            this.btnAnketAdd.Location = new System.Drawing.Point(8, 75);
            this.btnAnketAdd.Name = "btnAnketAdd";
            this.btnAnketAdd.Size = new System.Drawing.Size(238, 29);
            this.btnAnketAdd.TabIndex = 8;
            this.btnAnketAdd.Text = "Yeni Anket Ekle";
            this.btnAnketAdd.UseVisualStyleBackColor = true;
            this.btnAnketAdd.Click += new System.EventHandler(this.btnAnketAdd_Click);
            // 
            // btnSonucView
            // 
            this.btnSonucView.Location = new System.Drawing.Point(96, 63);
            this.btnSonucView.Name = "btnSonucView";
            this.btnSonucView.Size = new System.Drawing.Size(210, 28);
            this.btnSonucView.TabIndex = 13;
            this.btnSonucView.Text = "Sonuçları Gör";
            this.btnSonucView.UseVisualStyleBackColor = true;
            this.btnSonucView.Click += new System.EventHandler(this.btnSonucView_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "admin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 251);
            this.Controls.Add(this.btnSonucView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnket);
            this.Controls.Add(this.cbAnket);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Anket Giriş";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnket;
        private System.Windows.Forms.Button btnAnket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnketAdd;
        private System.Windows.Forms.Button btnSonucView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

