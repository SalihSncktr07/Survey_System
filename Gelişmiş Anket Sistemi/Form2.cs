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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=anket.accdb");

        void baglantiKur()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        private void btnSecSil_Click(object sender, EventArgs e)
        {
            if (lstSec.SelectedIndex != -1)
            {
                lstSec.Items.RemoveAt(lstSec.SelectedIndex);
            }            
        }

        string SecBirlestir()
        {
            string sec = "";
            for (int i = 0; i < lstSec.Items.Count; i++)
            {
                sec += lstSec.Items[i].ToString() + "|";
            }
            sec = sec.Remove(sec.Length - 1, 1);
            return sec;
        }

        private void btnAnketKayit_Click(object sender, EventArgs e)
        {
            txtAnketAdi.Text = txtAnketAdi.Text.Replace('\'',' ');
            baglantiKur();
            string sql_Ekle = "INSERT INTO anket_sorulari(anket_soru,anket_cevap) VALUES('" + txtAnketAdi.Text + "','" + SecBirlestir() + "')";
            OleDbCommand cmd_Ekle = new OleDbCommand(sql_Ekle, baglanti);
            cmd_Ekle.ExecuteNonQuery();
            baglanti.Close();

            lstSec.Items.Clear();
            txtAnketAdi.Text = "";
            txtSec.Text = "";

            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btnSecEkle_Click(object sender, EventArgs e)
        {
            lstSec.Items.Add(txtSec.Text);
            txtSec.Text = "";
        }

    }
}
