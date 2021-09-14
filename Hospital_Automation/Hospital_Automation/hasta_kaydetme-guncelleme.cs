using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Automation
{
    public partial class hasta_kaydetme_guncelleme : Form
    {
        public hasta_kaydetme_guncelleme()
        {
            InitializeComponent();
        }
        
        public void kayit()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.\MSSSQLSERVER;Initial Catalog=HospitalAutomation;Integrated Security=True;Pooling=False");
            baglan.Open();
            SqlCommand sorgu = new SqlCommand("select * from kayit where TC = '" + TextBox1.Text + "'", baglan);
            if (TextBox1.Text == "")
            { errorProvider1.SetError(TextBox1, "T.C. GİRİLMESİ ZORUNLU!"); }
            else
            {
                
               SqlDataReader oku = sorgu.ExecuteReader();
                if (oku.Read())
                { MessageBox.Show("KAYITLI HASTA!"); }
                else
                {
                    oku.Close();
                    SqlCommand kayit = new SqlCommand("insert into kayit (TC,ADI,SOYADI,DoğumTarihi,CEP,CİNSİYETİ,SİGORTA,KanGrubu,BabaAdı,AnneAdı,foto) values (@TC, @ADI, @SOYADI, @DoğumTarihi, @CEP, @CİNSİYETİ, @SİGORTA, @KanGrubu, @BabaAdı, @AnneAdı,@foto)", baglan);
                    kayit.Parameters.AddWithValue("@TC", TextBox1.Text);
                    kayit.Parameters.AddWithValue("@ADI", TextBox2.Text);
                    kayit.Parameters.AddWithValue("@SOYADI", TextBox3.Text);
                    kayit.Parameters.AddWithValue("@DoğumTarihi", DateTimePicker1.Value);
                    kayit.Parameters.AddWithValue("@CEP", MaskedTextBox1.Text);
                    kayit.Parameters.AddWithValue("@CİNSİYETİ", ComboBox1.Text);
                    kayit.Parameters.AddWithValue("@SİGORTA", ComboBox2.Text);
                    kayit.Parameters.AddWithValue("@KanGrubu", ComboBox3.Text);
                    kayit.Parameters.AddWithValue("@BabaAdı", TextBox4.Text);
                    kayit.Parameters.AddWithValue("@AnneAdı", TextBox5.Text);
                    kayit.Parameters.AddWithValue("@foto", PictureBox1.Tag.ToString());
                    PictureBox1.Image.Save(@"..\..\Image\" + PictureBox1.Tag.ToString());
                    kayit.ExecuteNonQuery();
                    
                    MessageBox.Show("KAYIT BAŞARILI.");
                }
                baglan.Close();
            }
        }

       public void guncelleme()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.\MSSSQLSERVER;Initial Catalog=HospitalAutomation;Integrated Security=True;Pooling=False");
            SqlCommand guncelleme = new SqlCommand("update kayit set  ADI=@ADI, SOYADI=@SOYADI, DoğumTarihi=@DoğumTarihi, CEP=@CEP, CİNSİYETİ=@CİNSİYETİ, SİGORTA=@SİGORTA, KanGrubu=@KanGrubu, BabaAdı=@BabaAdı, AnneAdı=@AnneAdı, foto=@foto where TC=@TC", baglan);
            baglan.Open();
            if (TextBox1.Text == "")
            { errorProvider1.SetError(TextBox1, "T.C. GİRİLMESİ ZORUNLU!"); }
            else
            {
               
               
                guncelleme.Parameters.AddWithValue("@TC", TextBox1.Text);
                guncelleme.Parameters.AddWithValue("@ADI", TextBox2.Text);
                guncelleme.Parameters.AddWithValue("@SOYADI", TextBox3.Text);
                guncelleme.Parameters.AddWithValue("@DoğumTarihi", DateTimePicker1.Text);
                guncelleme.Parameters.AddWithValue("@CEP", MaskedTextBox1.Text);
                guncelleme.Parameters.AddWithValue("@CİNSİYETİ", ComboBox1.Text);
                guncelleme.Parameters.AddWithValue("@SİGORTA", ComboBox2.Text);
                guncelleme.Parameters.AddWithValue("@KanGrubu", ComboBox3.Text);
                guncelleme.Parameters.AddWithValue("@BabaAdı", TextBox4.Text);
                guncelleme.Parameters.AddWithValue("@AnneAdı", TextBox5.Text);
                guncelleme.Parameters.AddWithValue("@foto", PictureBox1.Tag.ToString());
                PictureBox1.Image.Save(@"..\..\Image\" + PictureBox1.Tag.ToString());
             
                guncelleme.ExecuteNonQuery();
                //ms.Close();
                baglan.Close();
                MessageBox.Show("GÜNCELLEME BAŞARILI.");
                
            }
        }

        private void bt_kaydet_Click(object sender, EventArgs e)
        { kayit(); }

        private void bt_guncelle_Click(object sender, EventArgs e)
        { guncelleme(); }
        private void bt_resimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog resim = new OpenFileDialog();
            resim.ShowDialog();
            resim.Filter = "Resim Dosyaları |*.jpg;*.bmp;*.png";
            resim.Title = "Resim Seçiniz...";
            if (resim.ShowDialog() == DialogResult.OK)
            { PictureBox1.Image = Image.FromFile(resim.FileName); }
        }

        private void bt_resimsil_Click(object sender, EventArgs e)
        {
            PictureBox1.Image = PictureBox2.Image;
            File.Delete(@"..\..\Image\" + PictureBox1.Tag.ToString());
            PictureBox1.Tag = null;
        }

        private void hasta_kaydetme_guncelleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            hasta_guncelleme_silme hgsDG = new hasta_guncelleme_silme();
            if (bt_guncelle.Enabled == true)
            {
                hgsDG.DGkisilistele();
                hgsDG.Show();
            }
        }

      

        private void tb_yetkilikodu_KeyDown(object sender, KeyEventArgs e)
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.\MSSSQLSERVER;Initial Catalog=HospitalAutomation;Integrated Security=True;Pooling=False");
            if (e.KeyCode == Keys.Enter)
            {
                if (tb_yetkilikodu.Text == "") { errorProvider1.SetError(tb_yetkilikodu, "YETKİLİ KODU'NU GİRİNİZ!"); }
                else
                {
                    errorProvider1.Clear();
                    baglan.Open();
                    SqlCommand yetkilikodsorgu = new SqlCommand("select * from yetkili where KOD = '" + tb_yetkilikodu.Text + "'", baglan);
                    SqlDataReader kodoku = yetkilikodsorgu.ExecuteReader();
                    if (kodoku.Read())
                    {
                        tb_yetkilikodu.Visible = false;
                        TextBox1.Enabled = true;
                        tb_yetkilikodu.Clear();
                    }
                    else { errorProvider1.SetError(tb_yetkilikodu, "YANLIŞ KOD!"); }
                    baglan.Close();
                }
            }
        }

        private void tb_yetkilikodu_TextChanged(object sender, EventArgs e)
        {
            if (tb_yetkilikodu.Text == "") { errorProvider1.SetError(tb_yetkilikodu, "YETKİLİ KODU'NU GİRİNİZ!"); }
            else if (tb_yetkilikodu.Text != "") { errorProvider1.Clear(); }
        }

        private void bt_resimsec_Click_1(object sender, EventArgs e)
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Resim Dosyası|*.jpeg;*.jpg";
           DialogResult cvp= openFile.ShowDialog();
            if (cvp==DialogResult.OK)
            {
                PictureBox1.Image = Image.FromFile(openFile.FileName);
               
                PictureBox1.Tag = openFile.SafeFileName;
            }
            

        }

    }
}
