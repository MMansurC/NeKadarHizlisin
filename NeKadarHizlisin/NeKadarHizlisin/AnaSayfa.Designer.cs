
namespace NeKadarHizlisin
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnArtan = new System.Windows.Forms.Button();
            this.btnAzalan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cikis = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ne Kadar Hızlısın?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.btnArtan);
            this.panel1.Controls.Add(this.btnAzalan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 200);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Tomato;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlus.Location = new System.Drawing.Point(375, 175);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(25, 25);
            this.btnPlus.TabIndex = 99;
            this.btnPlus.TabStop = false;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnArtan
            // 
            this.btnArtan.BackColor = System.Drawing.Color.Tomato;
            this.btnArtan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArtan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnArtan.Location = new System.Drawing.Point(203, 90);
            this.btnArtan.Name = "btnArtan";
            this.btnArtan.Size = new System.Drawing.Size(180, 40);
            this.btnArtan.TabIndex = 5;
            this.btnArtan.TabStop = false;
            this.btnArtan.Text = "Artan Süre";
            this.btnArtan.UseVisualStyleBackColor = false;
            this.btnArtan.Click += new System.EventHandler(this.btnArtanSure_Click);
            // 
            // btnAzalan
            // 
            this.btnAzalan.BackColor = System.Drawing.Color.Tomato;
            this.btnAzalan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzalan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAzalan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAzalan.Location = new System.Drawing.Point(17, 90);
            this.btnAzalan.Name = "btnAzalan";
            this.btnAzalan.Size = new System.Drawing.Size(180, 40);
            this.btnAzalan.TabIndex = 3;
            this.btnAzalan.TabStop = false;
            this.btnAzalan.Text = "Azalan Süre";
            this.btnAzalan.UseVisualStyleBackColor = false;
            this.btnAzalan.Click += new System.EventHandler(this.btnAzalanSure_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1100;
            this.timer1.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.LightSalmon;
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Image = ((System.Drawing.Image)(resources.GetObject("cikis.Image")));
            this.cikis.Location = new System.Drawing.Point(388, 10);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(22, 22);
            this.cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cikis.TabIndex = 3;
            this.cikis.TabStop = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(420, 220);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ne Kadar Hızlısın?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAzalan;
        private System.Windows.Forms.Button btnArtan;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox cikis;
    }
}

