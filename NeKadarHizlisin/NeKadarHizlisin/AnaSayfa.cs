using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeKadarHizlisin
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private string secim1 = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void tusdevredisi()
        {
            btnPlus.Enabled = false;
            btnArtan.Enabled = false;
            btnAzalan.Enabled = false;
            btnPlus.BackColor = Color.LightSalmon;
            btnArtan.BackColor = Color.LightSalmon;
            btnAzalan.BackColor = Color.LightSalmon;
        }
        private void btnAzalanSure_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            secim1 = "Azalan";
            //yukleniyor1.Visible = true;
            timer1.Start();
            tusdevredisi();
        }

        private void btnArtanSure_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            secim1 = "Artan";
            //yukleniyor1.Visible = true;
            timer1.Start();
            tusdevredisi();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            KelimeliForm kelimeliForm = new KelimeliForm();
            kelimeliForm.secim = secim1;
            this.Hide();
            kelimeliForm.Show();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            timer2.Start();
            //yukleniyor1.Visible = true;
            tusdevredisi();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            btnPlus.Enabled = true;
            btnPlus.BackColor = Color.Tomato;
            timer2.Stop();
            KelimeEkle kelimeEkle = new KelimeEkle();
            this.Hide();
            kelimeEkle.Show();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
