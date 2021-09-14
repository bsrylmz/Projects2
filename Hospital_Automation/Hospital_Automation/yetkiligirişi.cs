using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Automation
{
    public partial class yetkiligirişi : Form
    {
        public yetkiligirişi()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=.\MSSSQLSERVER;Initial Catalog=HospitalAutomation;Integrated Security=True;Pooling=False");
        private void Button1_Click(object sender, EventArgs e)
        {
            giris kontrol = new giris();
            if (TextBox1.Text == "")
            { errorProvider1.SetError(TextBox1, "YETKİLİ KODU'NU GİRİNİZ!"); }
            else
            {
                errorProvider1.Clear();
                baglan.Open();
                SqlCommand sorgu = new SqlCommand("Select *From yetkili where KOD = '" + TextBox1.Text + "'", baglan);
                SqlDataReader oku = sorgu.ExecuteReader();
                if (oku.Read())
                {
                    kontrol.Show();
                    this.Hide();
                }
                else
                { errorProvider1.SetError(TextBox1, "YANLIŞ KOD!"); }
                baglan.Close();

            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text == "") { errorProvider1.SetError(TextBox1, "YETKİLİ KODU'NU GİRİNİZ!"); }
            else if (TextBox1.Text != "") { errorProvider1.Clear(); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
