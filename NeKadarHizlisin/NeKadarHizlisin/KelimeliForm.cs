using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace NeKadarHizlisin
{
    public partial class KelimeliForm : Form
    {
        public KelimeliForm()
        {
            InitializeComponent();
        }
        private string[] secilenKelimeler = new string[120];
        private void KelimeliForm_Load(object sender, EventArgs e)
        {
            panel2.Size = new Size(580, 381);
            KelimeGirdisi.CharacterCasing = CharacterCasing.Lower;
            baslat.Focus();
            if (secim == "Artan")
            {
                progressBar1.Maximum = 30;
                progressBar1.Value = 0;
                chck30.Visible=false;
                chck60.Visible=false;
            }
        }

        public string secim;

        private void kelimeleriSec()
        {
            dogrusayac = 0;
            yanlissayac = 0;
            int i = 0;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\NeKadarHizlisin.accdb");
            baglanti.Open();
            OleDbCommand kelimeleriSirala = new OleDbCommand("SELECT TOP 119 Kelime FROM Kelimeler ORDER BY RND(-Timer() * [Kimlik])", baglanti);
            OleDbDataReader dr = kelimeleriSirala.ExecuteReader();
            while (dr.Read())
            {
                if (i == 120)
                {
                    break;
                }
                secilenKelimeler[i] = dr[0].ToString();
                if (i == 0)
                {
                    lblSimdiki.Text = secilenKelimeler[i];
                }
                else if (i == 1)
                {
                    lblSonraki1.Text = secilenKelimeler[i];
                }
                else if (i == 2)
                {
                    lblSonraki2.Text = secilenKelimeler[i];
                }
                i++;
            }
            baglanti.Close();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }

        private void chck30_CheckedChanged(object sender, EventArgs e)
        {
            if (chck30.Checked == true)
            {
                chck60.Checked = false;
            }
            baslat.Focus();
        }

        private void chch60_CheckedChanged(object sender, EventArgs e)
        {
            if (chck60.Checked == true)
            {
                chck30.Checked = false;
            }
            baslat.Focus();
        }

        private void KelimeliForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                chck60.Visible = false;
                chck30.Visible = false;
                baslat.Visible = false;
                geri.Visible = false;
                yukleniyor1.Visible = true;
                label1.Text = "Hazır Olun.";
                yukleme.Start();
            }
        }

        private void yukleme_Tick(object sender, EventArgs e)
        {
            kelimeleriSec();
            yukleniyor1.Visible = false;
            lblGeriSayim.Visible = true;
            geriSayim.Start();
            yukleme.Stop();
        }

        private DateTime baslangic;
        private void geriSayim_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblGeriSayim.Text) == 1)
            {
                panel2.Visible = false;
                KelimeGirdisi.Focus();
                if (secim == "Azalan")
                {
                    KalanSure.Start();
                }
                else if (secim == "Artan")
                {
                    baslangic = DateTime.Now;
                }
                geri.Visible = true;
                geriSayim.Stop();
            }
            else
            {
                lblGeriSayim.Text = Convert.ToString(Convert.ToInt32(lblGeriSayim.Text) - 1);
            }
        }

        private int sayi = 4;
        private int dogrusayac = 0, yanlissayac = 0, toplamharf = 0, dogruharf = 0;

        private void KelimeGirdisi_TextChanged(object sender, EventArgs e)
        {
            if (lblSimdiki.Text.Length < KelimeGirdisi.TextLength)
            {
                KelimeGirdisi.ForeColor = Color.DarkRed;
            }
            else
            {
                for (int sayi = 0; sayi < KelimeGirdisi.TextLength; sayi++)
                {
                    if (lblSimdiki.Text[sayi] == KelimeGirdisi.Text[sayi])
                    {
                        KelimeGirdisi.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        KelimeGirdisi.ForeColor = Color.DarkRed;
                        break;
                    }
                }
            }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }

        private void btnYenidenDene_Click(object sender, EventArgs e)
        {
            KelimeliForm kelimeliForm = new KelimeliForm();
            kelimeliForm.secim = secim;
            this.Hide();
            kelimeliForm.Show();
        }

        private void KalanSure_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 0)
            {
                KelimeGirdisi.Enabled = false;
                pnlSonuc.Visible = true;
                if (secim == "Azalan")
                {
                    panel3.Location = new Point(66, 73);
                }
                lblSonraki2.Visible = false;
                geri.Visible = false;
                KalanSure.Stop();
            }
            else
            {
                if (chck30.Checked == true)
                {
                    progressBar1.Value -= 2;
                }
                else if (chck60.Checked == true)
                {
                    progressBar1.Value--;
                }
            }
        }

        private float basari;
        private void KelimeGirdisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            if (e.KeyChar == Convert.ToChar(Keys.Return) || e.KeyChar == Convert.ToChar(Keys.Space))
            {
                if (KelimeGirdisi.TextLength > 1)
                {
                    if (secim == "Artan")
                    {
                        progressBar1.Value++;
                    }
                    if (KelimeGirdisi.Text == lblSimdiki.Text)
                    {
                        dogrusayac++;
                        toplamharf += lblSimdiki.Text.Length;
                        dogruharf += lblSimdiki.Text.Length;
                        lblDogruKelime.Text = Convert.ToString(dogrusayac);
                        lblOnceki.ForeColor = Color.Green;
                    }
                    else
                    {
                        yanlissayac++;
                        toplamharf += lblSimdiki.Text.Length;
                        if (lblSimdiki.Text.Length <= KelimeGirdisi.TextLength)
                        {
                            for(int sayi = 0; sayi < lblSimdiki.Text.Length; sayi++)
                            {
                                if (lblSimdiki.Text[sayi] == KelimeGirdisi.Text[sayi])
                                {
                                    dogruharf++;
                                }
                            }
                        }
                        else
                        {
                            for(int sayi = 0; sayi < KelimeGirdisi.TextLength; sayi++)
                            {
                                if (lblSimdiki.Text[sayi] == KelimeGirdisi.Text[sayi])
                                {
                                    dogruharf++;
                                }
                            }
                        }
                        
                        
                        lblYanlisKelime.Text = Convert.ToString(yanlissayac);
                        lblOnceki.ForeColor = Color.Red;
                    }
                    basari = dogruharf * 100F / toplamharf;
                    BasariOrani.Text = "%" + Convert.ToString(Math.Round(basari, 2));
                    lblDogruHarf.Text = Convert.ToString(dogruharf + "/" + toplamharf);
                    KelimeGirdisi.Text = "";
                    if ((sayi > 119 && secim=="Azalan") || (sayi>30 && secim=="Artan"))
                    {
                        lblOnceki.Text = lblSimdiki.Text;
                        lblSimdiki.Text = lblSonraki1.Text;
                        lblSonraki1.Text = lblSonraki2.Text;
                        lblSonraki2.Text = "";
                        if (sayi > 32 && secim=="Artan")
                        {
                            DateTime bitis = DateTime.Now;
                            TimeSpan hesap = baslangic - bitis;
                            lblGecenSure.Text = Convert.ToString(-hesap.Minutes) + " dk " + Convert.ToString(-hesap.Seconds) + " sn " + Convert.ToString(-hesap.Milliseconds) + " ms";
                            lblGecenSure.Visible = true;
                            KelimeGirdisi.Enabled = false;
                            pnlSonuc.Visible = true;
                            geri.Visible = false;
                            KalanSure.Stop();
                        }
                    }
                    else
                    {
                        lblOnceki.Text = lblSimdiki.Text;
                        lblSimdiki.Text = lblSonraki1.Text;
                        lblSonraki1.Text = lblSonraki2.Text;
                        lblSonraki2.Text = secilenKelimeler[sayi];
                    }
                    sayi++;
                }

            }
        }
    }
}
