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

namespace NeKadarHizlisin
{
    public partial class KelimeEkle : Form
    {
        public KelimeEkle()
        {
            InitializeComponent();
        }

        private void KelimeEkle_Load(object sender, EventArgs e)
        {
            KelimeGirdisi.CharacterCasing = CharacterCasing.Lower;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\NeKadarHizlisin.accdb");
            baglanti.Open();
            OleDbCommand say = new OleDbCommand("SELECT COUNT(*) FROM Kelimeler", baglanti);
            OleDbDataReader dr =say.ExecuteReader();
            while (dr.Read())
            {
                lblKelimeSayisi.Text = Convert.ToString(dr.GetInt32(0));
            }
            baglanti.Close();
            KelimeGirdisi.Focus();
        }

        private void KelimeGirdisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (KelimeGirdisi.TextLength > 1)
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\NeKadarHizlisin.accdb");
                    baglanti.Open();
                    OleDbDataReader dr;
                    OleDbCommand kelimeVarMi = new OleDbCommand("SELECT Kelime FROM Kelimeler WHERE Kelime='" + KelimeGirdisi.Text + "'", baglanti);
                    dr = kelimeVarMi.ExecuteReader();
                    if (dr.Read())
                    {
                        if(label1.Text== "Eklemek için Enter'a basın.")
                        {
                            KelimeGirdisi.ResetText();
                            hata2.Visible = true;
                            timer1.Start();
                        }
                        else
                        {
                            hata3.Visible = true;
                            timer1.Start();
                        }
                    }
                    else
                    {
                        if (label1.Text == "Eklemek için Enter'a basın.")
                        {
                            OleDbCommand kelimeEkle = new OleDbCommand("INSERT INTO Kelimeler (Kelime) VALUES ('" + KelimeGirdisi.Text + "')", baglanti);
                            kelimeEkle.ExecuteNonQuery();
                            dataGridView1.Rows.Insert(0, KelimeGirdisi.Text);
                            dataGridView1.ClearSelection();
                            KelimeGirdisi.ResetText();
                            lblKelimeSayisi.Text = Convert.ToString(Convert.ToInt32(lblKelimeSayisi.Text) + 1);
                        }
                        else
                        {
                            OleDbCommand kelimeGuncelle = new OleDbCommand("UPDATE Kelimeler SET Kelime='" + KelimeGirdisi.Text + "' WHERE Kelime='" + dataGridView1.SelectedCells[0].Value.ToString() + "'", baglanti);
                            kelimeGuncelle.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                            dataGridView1.Rows.Insert(0, KelimeGirdisi.Text);
                            dataGridView1.ClearSelection();
                            KelimeGirdisi.ResetText();
                            label1.Text = "Eklemek için Enter'a basın.";
                            lblSecileniSil.Visible = false;
                            lblSecimiKaldir.Visible = false;
                        }
                    }
                    baglanti.Close();
                }
                else
                {
                    KelimeGirdisi.ResetText();
                    hata1.Visible = true;
                    timer1.Start();
                }
            }
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hata1.Visible = false;
            hata2.Visible = false;
            hata3.Visible = false;
            timer1.Stop();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                this.Hide();
                anaSayfa.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Geri dönerseniz eklediğiniz verileri sonradan düzenleyemezsiniz.\nEmin misiniz?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AnaSayfa anaSayfa = new AnaSayfa();
                    this.Hide();
                    anaSayfa.Show();
                }
            }
        }

        private void lblSecimiKaldir_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            lblSecimiKaldir.Visible = false;
            lblSecileniSil.Visible = false;
            KelimeGirdisi.ResetText();
            label1.Text = "Eklemek için Enter'a basın.";
            KelimeGirdisi.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KelimeGirdisi.Text = dataGridView1.SelectedCells[0].Value.ToString();
            lblSecimiKaldir.Visible = true;
            lblSecileniSil.Visible = true;
            label1.Text = "Güncellemek için Enter'a basın.";
            KelimeGirdisi.Focus();
        }

        private void lblSecileniSil_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\NeKadarHizlisin.accdb");
            baglanti.Open();
            OleDbCommand secilenSil = new OleDbCommand("DELETE * FROM Kelimeler WHERE Kelime='" + dataGridView1.SelectedCells[0].Value.ToString() + "'", baglanti);
            secilenSil.ExecuteNonQuery();
            baglanti.Close();
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            lblSecileniSil.Visible = false;
            lblSecimiKaldir.Visible = false;
            KelimeGirdisi.ResetText();
            KelimeGirdisi.Focus();
            label1.Text = "Eklemek için Enter'a basın.";
            dataGridView1.ClearSelection();
            lblKelimeSayisi.Text = Convert.ToString(Convert.ToInt32(lblKelimeSayisi.Text) - 1);

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
