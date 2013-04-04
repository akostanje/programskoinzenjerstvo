namespace nogometPI
{
    partial class frmUpravljanjeDodaj
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
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblRazinaPrava = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pravaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.sql25907DataSet = new nogometPI.sql25907DataSet();
            this.pravaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pravaTableAdapter = new nogometPI.sql25907DataSetTableAdapters.pravaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pravaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql25907DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(13, 31);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(13, 62);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka";
            // 
            // lblRazinaPrava
            // 
            this.lblRazinaPrava.AutoSize = true;
            this.lblRazinaPrava.Location = new System.Drawing.Point(13, 91);
            this.lblRazinaPrava.Name = "lblRazinaPrava";
            this.lblRazinaPrava.Size = new System.Drawing.Size(70, 13);
            this.lblRazinaPrava.TabIndex = 2;
            this.lblRazinaPrava.Text = "Razina prava";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pravaBindingSource1;
            this.comboBox1.DisplayMember = "naziv";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "idPrava";
            // 
            // pravaBindingSource
            // 
            this.pravaBindingSource.DataMember = "prava";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(26, 126);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(104, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj korisnika";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(136, 126);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // sql25907DataSet
            // 
            this.sql25907DataSet.DataSetName = "sql25907DataSet";
            this.sql25907DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pravaBindingSource1
            // 
            this.pravaBindingSource1.DataMember = "prava";
            this.pravaBindingSource1.DataSource = this.sql25907DataSet;
            // 
            // pravaTableAdapter
            // 
            this.pravaTableAdapter.ClearBeforeFill = true;
            // 
            // frmUpravljanjeDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 158);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblRazinaPrava);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpravljanjeDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj novog korisnika";
            this.Load += new System.EventHandler(this.frmUpravljanjeDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pravaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql25907DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblRazinaPrava;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource pravaBindingSource;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private sql25907DataSet sql25907DataSet;
        private System.Windows.Forms.BindingSource pravaBindingSource1;
        private sql25907DataSetTableAdapters.pravaTableAdapter pravaTableAdapter;
    }
}