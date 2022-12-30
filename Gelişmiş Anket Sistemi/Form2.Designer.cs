namespace Gelişmiş_Anket_Sistemi
{
    partial class Form2
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
            this.txtAnketAdi = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSec = new System.Windows.Forms.ListBox();
            this.btnSecEkle = new System.Windows.Forms.Button();
            this.btnAnketKayit = new System.Windows.Forms.Button();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anket soru :";
            // 
            // txtAnketAdi
            // 
            this.txtAnketAdi.Location = new System.Drawing.Point(90, 6);
            this.txtAnketAdi.Name = "txtAnketAdi";
            this.txtAnketAdi.Size = new System.Drawing.Size(242, 24);
            this.txtAnketAdi.TabIndex = 1;
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(90, 33);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(145, 24);
            this.txtSec.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şık adi :";
            // 
            // lstSec
            // 
            this.lstSec.FormattingEnabled = true;
            this.lstSec.ItemHeight = 17;
            this.lstSec.Location = new System.Drawing.Point(90, 64);
            this.lstSec.Name = "lstSec";
            this.lstSec.Size = new System.Drawing.Size(242, 106);
            this.lstSec.TabIndex = 4;
            // 
            // btnSecEkle
            // 
            this.btnSecEkle.Location = new System.Drawing.Point(241, 33);
            this.btnSecEkle.Name = "btnSecEkle";
            this.btnSecEkle.Size = new System.Drawing.Size(91, 25);
            this.btnSecEkle.TabIndex = 5;
            this.btnSecEkle.Text = "Şık\'ı Listeye Ekle";
            this.btnSecEkle.UseVisualStyleBackColor = true;
            this.btnSecEkle.Click += new System.EventHandler(this.btnSecEkle_Click);
            // 
            // btnAnketKayit
            // 
            this.btnAnketKayit.Location = new System.Drawing.Point(90, 208);
            this.btnAnketKayit.Name = "btnAnketKayit";
            this.btnAnketKayit.Size = new System.Drawing.Size(242, 27);
            this.btnAnketKayit.TabIndex = 6;
            this.btnAnketKayit.Text = "Anketi Kayit Et";
            this.btnAnketKayit.UseVisualStyleBackColor = true;
            this.btnAnketKayit.Click += new System.EventHandler(this.btnAnketKayit_Click);
            // 
            // btnSecSil
            // 
            this.btnSecSil.Location = new System.Drawing.Point(90, 177);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(242, 25);
            this.btnSecSil.TabIndex = 7;
            this.btnSecSil.Text = "Seçili Şık\'ı Sil";
            this.btnSecSil.UseVisualStyleBackColor = true;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 271);
            this.Controls.Add(this.btnSecSil);
            this.Controls.Add(this.btnAnketKayit);
            this.Controls.Add(this.btnSecEkle);
            this.Controls.Add(this.lstSec);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnketAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Anket Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnketAdi;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSec;
        private System.Windows.Forms.Button btnSecEkle;
        private System.Windows.Forms.Button btnAnketKayit;
        private System.Windows.Forms.Button btnSecSil;
    }
}