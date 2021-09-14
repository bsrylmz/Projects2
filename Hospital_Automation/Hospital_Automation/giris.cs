using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Automation
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        private void YeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            hasta_kaydetme_guncelleme hkg = new hasta_kaydetme_guncelleme();
            hkg.Show();
            this.Hide();
        }

        private void KayıtGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hasta_guncelleme_silme hgsDG = new hasta_guncelleme_silme();
            hgsDG.Show();
            
        }

        private void HASTAKAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
