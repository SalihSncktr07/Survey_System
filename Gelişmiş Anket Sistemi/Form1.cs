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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void btnAnketAdd_Click(object sender, EventArgs e)
        {
            if (txtNick.Text == "admin" && txtPass.Text == "admin")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre");
            }
        }

        private void cbAnket_Click(object sender, EventArgs e)
        {
            cbAnket.Items.Clear();

            baglantiKur();
            string sql_Getir = "SELECT DISTINCT anket_soru FROM anket_sorulari";
            OleDbCommand cmd_Getir = new OleDbCommand(sql_Getir,baglanti);
            OleDbDataReader oku;
            oku = cmd_Getir.ExecuteReader();
            while (oku.Read())
            {
                cbAnket.Items.Add(oku[0]);
            }

            baglanti.Close();
        }

        private void btnAnket_Click(object sender, EventArgs e)
        {
            if (cbAnket.SelectedIndex != -1)
            {
                Form3 frm3 = new Form3();
                frm3.anket_Sorusu = cbAnket.Text;
                frm3.Show();                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Anket Sorusunu Seçiniz.");
            }
            
        }

        private void btnSonucView_Click(object sender, EventArgs e)
        {
            if (cbAnket.SelectedIndex != -1)
            {
                Form4 frm4 = new Form4();
                frm4.anket_Sorusu = cbAnket.Text;
                frm4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Anket Sorusunu Seçiniz.");
            }
        }
            
    }
}
