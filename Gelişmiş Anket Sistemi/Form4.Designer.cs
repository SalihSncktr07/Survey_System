namespace Gelişmiş_Anket_Sistemi
{
    partial class Form4
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
            this.lblAnketSoru = new System.Windows.Forms.Label();
            this.lblOy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anket Sorusu : ";
            // 
            // lblAnketSoru
            // 
            this.lblAnketSoru.AutoSize = true;
            this.lblAnketSoru.Location = new System.Drawing.Point(82, 9);
            this.lblAnketSoru.Name = "lblAnketSoru";
            this.lblAnketSoru.Size = new System.Drawing.Size(35, 13);
            this.lblAnketSoru.TabIndex = 1;
            this.lblAnketSoru.Text = "label2";
            // 
            // lblOy
            // 
            this.lblOy.AutoSize = true;
            this.lblOy.Location = new System.Drawing.Point(123, 32);
            this.lblOy.Name = "lblOy";
            this.lblOy.Size = new System.Drawing.Size(35, 13);
            this.lblOy.TabIndex = 5;
            this.lblOy.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Kullanılan Oy :";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 221);
            this.Controls.Add(this.lblOy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAnketSoru);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.Text = "Anket Sonuçları";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnketSoru;
        private System.Windows.Forms.Label lblOy;
        private System.Windows.Forms.Label label2;
    }
}