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
    public partial class frmUpravljanjeKorisnicima : Form
    {
        public frmUpravljanjeKorisnicima()
        {
            InitializeComponent();
        }

        private void frmUpravljanjeKorisnicima_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql25907DataSet.korisnici' table. You can move, or remove it, as needed.
            this.korisniciTableAdapter.Fill(this.sql25907DataSet.korisnici);

        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmUpravljanjeDodaj formaDodajKorisnika = new frmUpravljanjeDodaj();
            formaDodajKorisnika.Show();
        }
    }
}
