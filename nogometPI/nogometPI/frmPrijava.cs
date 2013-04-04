using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nogometPI
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
            txtKorisnickoIme.Focus();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                korisniciTableAdapter.FillByPrijava(sql25907DataSet.korisnici, txtKorisnickoIme.Text, mtxtLozinka.Text);
                if (sql25907DataSet.korisnici.Count != 1)
                {
                    MessageBox.Show("Prijava nije uspjela!");
                    txtKorisnickoIme.Text = "";
                    mtxtLozinka.Text = "";
                    txtKorisnickoIme.Focus();
                }
                else
                {
                    frmMain.prijavljeniKorisnik = txtKorisnickoIme.Text;
                    frmMain.logKorisnik.Text = "Prijavljeni ste kao: " + txtKorisnickoIme.Text;
                    frmMain.staticPrijava.Enabled = false;
                    frmMain.staticOdjava.Enabled = true;
                    if (txtKorisnickoIme.Text == "admin")
                    {
                        frmMain.staticUpravljanjeKorisnicima.Enabled = true;
                        frmMain.staticUpravljanjeKorisnicima.Visible = true;
                    }
                    this.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška sa spajanjem na bazu.");
            }
            
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql25907DataSet.korisnici' table. You can move, or remove it, as needed.
            this.korisniciTableAdapter.Fill(this.sql25907DataSet.korisnici);
            // TODO: This line of code loads data into the 'sql25907DataSet.korisnici' table. You can move, or remove it, as needed.
        }

    }
}
