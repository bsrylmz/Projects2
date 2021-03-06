using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Automation
{
    public partial class hasta_guncelleme_silme : Form
    {
        public hasta_guncelleme_silme()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=.\MSSSQLSERVER;Initial Catalog=HospitalAutomation;Integrated Security=True;Pooling=False");
        public void DGkisilistele()
        {
            //SqlConnection baglan = new SqlConnection(@"Data Source=.\MSSSQLSERVER;Initial Catalog=HospitalAutomation;Integrated Security=True;Pooling=False");
            tb_yetkilikodu.Visible = false;
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *From kayit", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgv_kisilistele.DataSource = tablo;
            dgv_kisilistele.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_kisilistele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_kisilistele.ClearSelection();
            baglan.Close();
        }

        private void hasta_guncelleme_silme_DG_Load(object sender, EventArgs e)
        { DGkisilistele(); }

        private void dgv_kisilistele_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            hasta_kaydetme_guncelleme hkg = new hasta_kaydetme_guncelleme();
            hkg.Show();
           // hkg.checkBox1.Visible = true;
           // hkg.bt_kaydet.Enabled = false;
           // hkg.bt_guncelle.Enabled = true;
            hkg.TextBox1.Enabled = false;
           // hkg.label13.Visible = true;
           // hkg.tb_id.Text = dgv_kisilistele.CurrentRow.Cells["ID"].Value.ToString();
            hkg.TextBox1.Text = dgv_kisilistele.CurrentRow.Cells["TC"].Value.ToString();
            hkg.TextBox2.Text = dgv_kisilistele.CurrentRow.Cells["ADI"].Value.ToString();
            hkg.TextBox3.Text = dgv_kisilistele.CurrentRow.Cells["SOYADI"].Value.ToString();
            hkg.DateTimePicker1.Text = dgv_kisilistele.CurrentRow.Cells["DoğumTarihi"].Value.ToString();
           // hkg.MaskedTextBox1.Text = dgv_kisilistele.CurrentRow.Cells["CEP"].Value.ToString();
           // hkg.ComboBox1.Text = dgv_kisilistele.CurrentRow.Cells["CİNSİYETİ"].Value.ToString();
           // hkg.ComboBox2.Text = dgv_kisilistele.CurrentRow.Cells["SİGORTA"].Value.ToString();
          //  hkg.ComboBox3.Text = dgv_kisilistele.CurrentRow.Cells["KanGrubu"].Value.ToString();
            hkg.TextBox4.Text = dgv_kisilistele.CurrentRow.Cells["BabaAdı"].Value.ToString();
            hkg.TextBox5.Text = dgv_kisilistele.CurrentRow.Cells["AnneAdı"].Value.ToString();
            string resimyolu = @"..\..\Image\" + dgv_kisilistele.CurrentRow.Cells["foto"].Value.ToString();
            if (File.Exists(resimyolu))
            {
                hkg.PictureBox1.Image = Image.FromFile(resimyolu);
                hkg.PictureBox1.Tag = dgv_kisilistele.CurrentRow.Cells["foto"].Value.ToString();
            }
            
          //  hkg.PictureBox1.Image = (Image)dgv_kisilistele.CurrentRow.Cells["foto"].FormattedValue;


            Close();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_kisilistele.SelectedRows.Count == 0) { MessageBox.Show("Satır Seçiniz!"); }
            else
            {
                tb_yetkilikodu.Visible = true;
                if (tb_yetkilikodu.Text == "") { errorProvider1.SetError(tb_yetkilikodu, "YETKİLİ KODU'NU GİRİNİZ!"); }
                else
                {
                    errorProvider1.Clear();
                   baglan.Open();
                    SqlCommand yetkilikodsorgu = new SqlCommand("select * from yetkili where KOD = '" + tb_yetkilikodu.Text + "'", baglan);
                   SqlDataReader kodoku = yetkilikodsorgu.ExecuteReader();
                    if (kodoku.Read())
                    {
                       SqlCommand sil = new SqlCommand("delete from kayit where TC=@TC", baglan);
                        sil.Parameters.AddWithValue("@TC", dgv_kisilistele.CurrentRow.Cells["TC"].Value);
                        sil.ExecuteNonQuery();
                        baglan.Close();
                        DGkisilistele();
                        tb_yetkilikodu.Visible = false;
                    }
                    else
                    {
                        errorProvider1.SetError(tb_yetkilikodu, "YANLIŞ KOD!");
                        baglan.Close();
                    }
                }
            }
        }

        private void bt_ara_Click(object sender, EventArgs e)
        {
            if (tb_tc.Text == "")
            { DGkisilistele(); }
            else
            {
                baglan.Open();
                SqlDataAdapter tcsorgu = new SqlDataAdapter("select * from kayit where TC = '" + tb_tc.Text + "'", baglan);
                DataTable dt = new DataTable();
                tcsorgu.Fill(dt);
                dgv_kisilistele.DataSource = dt;
                dgv_kisilistele.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgv_kisilistele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                baglan.Close();
            }
        }
        private void tb_yetkilikodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { yenileToolStripMenuItem.PerformClick(); }
        }

        private void tb_yetkilikodu_TextChanged(object sender, EventArgs e)
        {
            if (tb_yetkilikodu.Text == "") { errorProvider1.SetError(tb_yetkilikodu, "YETKİLİ KODU'NU GİRİNİZ!"); }
            else if (tb_yetkilikodu.Text != "") { errorProvider1.Clear(); }
        }

        private void hasta_guncelleme_silme_Load(object sender, EventArgs e)
        {
            DGkisilistele();
        }
    }
}
