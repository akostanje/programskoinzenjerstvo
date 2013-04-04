namespace nogometPI
{
    partial class frmMain
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
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.ssMaintsLogirani = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.msMainmiKorisnik = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainmiPrijava = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainmiOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msMainmiIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainmiUpravljanje = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainmiKorisnicima = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainmiPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainmiUpute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msMainmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssMaintsLogirani});
            this.ssMain.Location = new System.Drawing.Point(0, 280);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(773, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // ssMaintsLogirani
            // 
            this.ssMaintsLogirani.Name = "ssMaintsLogirani";
            this.ssMaintsLogirani.Size = new System.Drawing.Size(88, 17);
            this.ssMaintsLogirani.Text = "Niste prijavljeni";
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainmiKorisnik,
            this.msMainmiUpravljanje,
            this.msMainmiPomoc});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(773, 24);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "menuStrip1";
            // 
            // msMainmiKorisnik
            // 
            this.msMainmiKorisnik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainmiPrijava,
            this.msMainmiOdjava,
            this.toolStripSeparator1,
            this.msMainmiIzlaz});
            this.msMainmiKorisnik.Name = "msMainmiKorisnik";
            this.msMainmiKorisnik.Size = new System.Drawing.Size(61, 20);
            this.msMainmiKorisnik.Text = "Korisnik";
            // 
            // msMainmiPrijava
            // 
            this.msMainmiPrijava.Name = "msMainmiPrijava";
            this.msMainmiPrijava.Size = new System.Drawing.Size(111, 22);
            this.msMainmiPrijava.Text = "Prijava";
            this.msMainmiPrijava.Click += new System.EventHandler(this.msMainmiPrijava_Click);
            // 
            // msMainmiOdjava
            // 
            this.msMainmiOdjava.Name = "msMainmiOdjava";
            this.msMainmiOdjava.Size = new System.Drawing.Size(111, 22);
            this.msMainmiOdjava.Text = "Odjava";
            this.msMainmiOdjava.Click += new System.EventHandler(this.msMainmiOdjava_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            // 
            // msMainmiIzlaz
            // 
            this.msMainmiIzlaz.Name = "msMainmiIzlaz";
            this.msMainmiIzlaz.Size = new System.Drawing.Size(111, 22);
            this.msMainmiIzlaz.Text = "Izlaz";
            this.msMainmiIzlaz.Click += new System.EventHandler(this.msMainmiIzlaz_Click);
            // 
            // msMainmiUpravljanje
            // 
            this.msMainmiUpravljanje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainmiKorisnicima});
            this.msMainmiUpravljanje.Name = "msMainmiUpravljanje";
            this.msMainmiUpravljanje.Size = new System.Drawing.Size(78, 20);
            this.msMainmiUpravljanje.Text = "Upravljanje";
            // 
            // msMainmiKorisnicima
            // 
            this.msMainmiKorisnicima.Name = "msMainmiKorisnicima";
            this.msMainmiKorisnicima.Size = new System.Drawing.Size(136, 22);
            this.msMainmiKorisnicima.Text = "Korisnicima";
            this.msMainmiKorisnicima.Click += new System.EventHandler(this.msMainmiKorisnicima_Click);
            // 
            // msMainmiPomoc
            // 
            this.msMainmiPomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainmiUpute,
            this.toolStripSeparator2,
            this.msMainmiAbout});
            this.msMainmiPomoc.Name = "msMainmiPomoc";
            this.msMainmiPomoc.Size = new System.Drawing.Size(57, 20);
            this.msMainmiPomoc.Text = "Pomoć";
            // 
            // msMainmiUpute
            // 
            this.msMainmiUpute.Name = "msMainmiUpute";
            this.msMainmiUpute.Size = new System.Drawing.Size(162, 22);
            this.msMainmiUpute.Text = "Korisničke upute";
            this.msMainmiUpute.Click += new System.EventHandler(this.msMainmiUpute_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // msMainmiAbout
            // 
            this.msMainmiAbout.Name = "msMainmiAbout";
            this.msMainmiAbout.Size = new System.Drawing.Size(162, 22);
            this.msMainmiAbout.Text = "O programu";
            this.msMainmiAbout.Click += new System.EventHandler(this.msMainmiAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 302);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nogomet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem msMainmiKorisnik;
        private System.Windows.Forms.ToolStripMenuItem msMainmiPrijava;
        private System.Windows.Forms.ToolStripMenuItem msMainmiOdjava;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem msMainmiIzlaz;
        private System.Windows.Forms.ToolStripMenuItem msMainmiUpravljanje;
        private System.Windows.Forms.ToolStripMenuItem msMainmiKorisnicima;
        private System.Windows.Forms.ToolStripMenuItem msMainmiPomoc;
        private System.Windows.Forms.ToolStripMenuItem msMainmiUpute;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem msMainmiAbout;
        private System.Windows.Forms.ToolStripStatusLabel ssMaintsLogirani;
    }
}

