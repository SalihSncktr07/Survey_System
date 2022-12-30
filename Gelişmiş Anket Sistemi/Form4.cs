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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string anket_Sorusu = "";

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=anket.accdb");
        int toplamOy = 0;
        int top = 56;
        void baglantiKur()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }        

        string SecenekleriGetir()
        {
            string sec = "";
            baglantiKur();
            string sql = "SELECT * FROM anket_sorulari WHERE anket_soru ='" + anket_Sorusu + "'";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            OleDbDataReader oku;
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                sec = oku[2].ToString();
            }
            return sec;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblAnketSoru.Text = anket_Sorusu;
            baglantiKur();
            string sql = "SELECT * FROM anket_sonuclari WHERE anket_soru = '" + anket_Sorusu + "'";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            OleDbDataReader oku;
            oku = cmd.ExecuteReader();
            string[] secenekler = SecenekleriGetir().Split('|');
            int[] adet = new int[secenekler.Length];
            while (oku.Read())
            {
                for (int i = 0; i < secenekler.Length; i++)
                {
                    if (secenekler[i] == oku[1].ToString())
                    {
                        adet[i]++;
                    }
                }
                toplamOy++;
            }
            baglanti.Close();

            for (int i = 0; i < secenekler.Length; i++)
            {
                Label lbl = new Label();
                ProgressBar pb = new ProgressBar();
                lbl.Left = 12;
                top += 23;
                lbl.Top = top;
                lbl.Text = secenekler[i] + " : " + adet[i].ToString();

                pb.Left = lbl.Size.Width + 20;
                pb.Top = top - 3;
                pb.Size = new Size(131, 17);

                if (toplamOy != 0)
                {
                    pb.Value = (100 * adet[i]) / toplamOy;
                }               
                
                this.Controls.Add(lbl);
                this.Controls.Add(pb);
            }

            lblOy.Text = toplamOy.ToString();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
