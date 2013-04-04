namespace nogometPI
{
    partial class frmPrijava
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
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.mtxtLozinka = new System.Windows.Forms.MaskedTextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.alblZaboravljenaLozinka = new System.Windows.Forms.LinkLabel();
            this.sql25907DataSet = new nogometPI.sql25907DataSet();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisniciTableAdapter = new nogometPI.sql25907DataSetTableAdapters.korisniciTableAdapter();
            this.tableAdapterManager = new nogometPI.sql25907DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.sql25907DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(111, 24);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(131, 20);
            this.txtKorisnickoIme.TabIndex = 0;
            // 
            // mtxtLozinka
            // 
            this.mtxtLozinka.Location = new System.Drawing.Point(111, 65);
            this.mtxtLozinka.Name = "mtxtLozinka";
            this.mtxtLozinka.PasswordChar = '*';
            this.mtxtLozinka.Size = new System.Drawing.Size(131, 20);
            this.mtxtLozinka.TabIndex = 1;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(18, 27);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 2;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(49, 68);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 3;
            this.lblLozinka.Text = "Lozinka";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(56, 106);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(137, 106);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // alblZaboravljenaLozinka
            // 
            this.alblZaboravljenaLozinka.AutoSize = true;
            this.alblZaboravljenaLozinka.Location = new System.Drawing.Point(78, 147);
            this.alblZaboravljenaLozinka.Name = "alblZaboravljenaLozinka";
            this.alblZaboravljenaLozinka.Size = new System.Drawing.Size(112, 13);
            this.alblZaboravljenaLozinka.TabIndex = 6;
            this.alblZaboravljenaLozinka.TabStop = true;
            this.alblZaboravljenaLozinka.Text = "Zaboravili ste lozinku?";
            // 
            // sql25907DataSet
            // 
            this.sql25907DataSet.DataSetName = "sql25907DataSet";
            this.sql25907DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataMember = "korisnici";
            this.korisniciBindingSource.DataSource = this.sql25907DataSet;
            // 
            // korisniciTableAdapter
            // 
            this.korisniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.korisniciTableAdapter = this.korisniciTableAdapter;
            this.tableAdapterManager.pravaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nogometPI.sql25907DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmPrijava
            // 
            this.AcceptButton = this.btnPrijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(265, 142);
            this.Controls.Add(this.alblZaboravljenaLozinka);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.mtxtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrijava";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPrijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sql25907DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.MaskedTextBox mtxtLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.LinkLabel alblZaboravljenaLozinka;
        private sql25907DataSet sql25907DataSet;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private sql25907DataSetTableAdapters.korisniciTableAdapter korisniciTableAdapter;
        private sql25907DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}