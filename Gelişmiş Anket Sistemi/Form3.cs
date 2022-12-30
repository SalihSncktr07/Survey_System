using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
namespace Gelişmiş_Anket_Sistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string anket_Sorusu = "";
        string sonuc = "";

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=anket.accdb");

        int top = 0;
        void baglantiKur()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblAnketSoru.Text = anket_Sorusu;

            baglantiKur();
            string sql = "SELECT * FROM anket_sorulari WHERE anket_soru='" + anket_Sorusu + "'";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            OleDbDataReader oku;
            oku = cmd.ExecuteReader();            
            while (oku.Read())
            {
                string[] secenekler = oku[2].ToString().Split('|');
                for (int i = 0; i < secenekler.Length; i++)
                {
                    RadioButton rb = new RadioButton();
                    rb.Left = 6;
                    top += 23;
                    rb.Top = top;
                    rb.Text = secenekler[i];
                    rb.Click += new EventHandler(rb_Click);
                    this.Controls.Add(rb);                   
                }
            }
            baglanti.Close();

            Button btn = new Button();
            btn.Left = 6;
            top+=23;
            btn.Top = top;
            btn.Size = new Size(150,30);
            btn.Text = "Oy veriniz.";
            btn.Click += new EventHandler(btn_Click);
            this.Controls.Add(btn);
          
        }

        void rb_Click(object sender, EventArgs e)
        {
            sonuc = ((RadioButton)sender).Text;
        }

        void btn_Click(object sender, EventArgs e)
        {
            baglantiKur();
            string sql = "INSERT INTO anket_sonuclari(anket_soru,anket_cevap) VALUES('" + anket_Sorusu + "','" + sonuc + "')";
            OleDbCommand cmd = new OleDbCommand(sql,baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Oy verdiğiniz için teşekkürler.");
            ((Button)sender).Enabled = false;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
