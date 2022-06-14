
namespace NeKadarHizlisin
{
    partial class KelimeEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelimeEkle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cikis = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.onemsiz = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKelimeSayisi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kelime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hata3 = new System.Windows.Forms.Label();
            this.lblSecileniSil = new System.Windows.Forms.Label();
            this.lblSecimiKaldir = new System.Windows.Forms.Label();
            this.hata2 = new System.Windows.Forms.Label();
            this.hata1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KelimeGirdisi = new System.Windows.Forms.TextBox();
            this.geri = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            this.onemsiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.cikis);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.onemsiz);
            this.panel2.Controls.Add(this.lblKelimeSayisi);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.hata3);
            this.panel2.Controls.Add(this.lblSecileniSil);
            this.panel2.Controls.Add(this.lblSecimiKaldir);
            this.panel2.Controls.Add(this.hata2);
            this.panel2.Controls.Add(this.hata1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.KelimeGirdisi);
            this.panel2.Controls.Add(this.geri);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 580);
            this.panel2.TabIndex = 3;
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.LightSalmon;
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Image = ((System.Drawing.Image)(resources.GetObject("cikis.Image")));
            this.cikis.Location = new System.Drawing.Point(378, 0);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(22, 22);
            this.cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cikis.TabIndex = 14;
            this.cikis.TabStop = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(156, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Toplam Kelime";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // onemsiz
            // 
            this.onemsiz.BackColor = System.Drawing.Color.Black;
            this.onemsiz.Controls.Add(this.label3);
            this.onemsiz.Location = new System.Drawing.Point(52, 270);
            this.onemsiz.Name = "onemsiz";
            this.onemsiz.Size = new System.Drawing.Size(300, 31);
            this.onemsiz.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Son Eklenen Kelimeler";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKelimeSayisi
            // 
            this.lblKelimeSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblKelimeSayisi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelimeSayisi.Location = new System.Drawing.Point(170, 253);
            this.lblKelimeSayisi.Name = "lblKelimeSayisi";
            this.lblKelimeSayisi.Size = new System.Drawing.Size(60, 17);
            this.lblKelimeSayisi.TabIndex = 12;
            this.lblKelimeSayisi.Text = "{x}";
            this.lblKelimeSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kelime});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(52, 300);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(300, 270);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Kelime
            // 
            this.Kelime.HeaderText = "Son Eklenen Kelimeler";
            this.Kelime.Name = "Kelime";
            this.Kelime.ReadOnly = true;
            this.Kelime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // hata3
            // 
            this.hata3.AutoSize = true;
            this.hata3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata3.ForeColor = System.Drawing.Color.Red;
            this.hata3.Location = new System.Drawing.Point(117, 78);
            this.hata3.Name = "hata3";
            this.hata3.Size = new System.Drawing.Size(166, 19);
            this.hata3.TabIndex = 9;
            this.hata3.Text = "# Güncelleme Başarısız.";
            this.hata3.Visible = false;
            // 
            // lblSecileniSil
            // 
            this.lblSecileniSil.AutoSize = true;
            this.lblSecileniSil.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblSecileniSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSecileniSil.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecileniSil.Location = new System.Drawing.Point(52, 254);
            this.lblSecileniSil.Name = "lblSecileniSil";
            this.lblSecileniSil.Size = new System.Drawing.Size(67, 15);
            this.lblSecileniSil.TabIndex = 8;
            this.lblSecileniSil.Text = "Seçileni Sil";
            this.lblSecileniSil.Visible = false;
            this.lblSecileniSil.Click += new System.EventHandler(this.lblSecileniSil_Click);
            // 
            // lblSecimiKaldir
            // 
            this.lblSecimiKaldir.AutoSize = true;
            this.lblSecimiKaldir.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblSecimiKaldir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSecimiKaldir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecimiKaldir.Location = new System.Drawing.Point(273, 254);
            this.lblSecimiKaldir.Name = "lblSecimiKaldir";
            this.lblSecimiKaldir.Size = new System.Drawing.Size(79, 15);
            this.lblSecimiKaldir.TabIndex = 7;
            this.lblSecimiKaldir.Text = "Seçimi Kaldır";
            this.lblSecimiKaldir.Visible = false;
            this.lblSecimiKaldir.Click += new System.EventHandler(this.lblSecimiKaldir_Click);
            // 
            // hata2
            // 
            this.hata2.AutoSize = true;
            this.hata2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata2.ForeColor = System.Drawing.Color.Red;
            this.hata2.Location = new System.Drawing.Point(106, 78);
            this.hata2.Name = "hata2";
            this.hata2.Size = new System.Drawing.Size(188, 19);
            this.hata2.TabIndex = 6;
            this.hata2.Text = "# Bu kelime zaten mevcut.";
            this.hata2.Visible = false;
            // 
            // hata1
            // 
            this.hata1.AutoSize = true;
            this.hata1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata1.ForeColor = System.Drawing.Color.Red;
            this.hata1.Location = new System.Drawing.Point(58, 78);
            this.hata1.Name = "hata1";
            this.hata1.Size = new System.Drawing.Size(285, 19);
            this.hata1.TabIndex = 4;
            this.hata1.Text = "# Kelimeler minimum 2 harften oluşmalı.";
            this.hata1.Visible = false;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(90, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eklemek için Enter\'a basın.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KelimeGirdisi
            // 
            this.KelimeGirdisi.BackColor = System.Drawing.Color.Bisque;
            this.KelimeGirdisi.Location = new System.Drawing.Point(110, 100);
            this.KelimeGirdisi.MaxLength = 12;
            this.KelimeGirdisi.Multiline = true;
            this.KelimeGirdisi.Name = "KelimeGirdisi";
            this.KelimeGirdisi.Size = new System.Drawing.Size(180, 27);
            this.KelimeGirdisi.TabIndex = 2;
            this.KelimeGirdisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KelimeGirdisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KelimeGirdisi_KeyPress);
            // 
            // geri
            // 
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.Image = ((System.Drawing.Image)(resources.GetObject("geri.Image")));
            this.geri.Location = new System.Drawing.Point(3, 3);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(30, 30);
            this.geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.geri.TabIndex = 1;
            this.geri.TabStop = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kelime Ekle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KelimeEkle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(420, 600);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KelimeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ne Kadar Hızlısın?";
            this.Load += new System.EventHandler(this.KelimeEkle_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            this.onemsiz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox geri;
        private System.Windows.Forms.TextBox KelimeGirdisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hata1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kelime;
        private System.Windows.Forms.Label hata2;
        private System.Windows.Forms.Label lblSecimiKaldir;
        private System.Windows.Forms.Label lblSecileniSil;
        private System.Windows.Forms.Label hata3;
        private System.Windows.Forms.Panel onemsiz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKelimeSayisi;
        private System.Windows.Forms.PictureBox cikis;
    }
}