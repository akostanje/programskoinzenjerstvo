using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace nogometPI
{
    public partial class frmMain : Form
    {
        public static string prijavljeniKorisnik = "Niste prijavljeni";
        public static ToolStripStatusLabel logKorisnik;
        public static ToolStripMenuItem staticPrijava, staticOdjava, staticUpravljanjeKorisnicima;

        public frmMain()
        {
            InitializeComponent();
        }

        
        //Ponavljanje koda pa da izbjegnemo ponovno pisanje
        private void otvoriPrijavu()
        {
            frmPrijava formaPrijave = new frmPrijava();
            formaPrijave.ShowDialog(this);
        }
        private void provjaraIzlaza()
        {
            frmIzlaz formaIzlaz = new frmIzlaz();
            formaIzlaz.ShowDialog();
            formaIzlaz.MdiParent = this;
            if (formaIzlaz.DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void onemoguceno()
        {
            msMainmiPrijava.Enabled = true;
            msMainmiOdjava.Enabled = false;
            msMainmiKorisnicima.Enabled = false;
            msMainmiKorisnicima.Visible = false;
            ssMaintsLogirani.Text = "Niste prijavljeni";
            prijavljeniKorisnik = "Niste prijavljeni";
        }
        //------------------------------------------------------------

        private void msMainmiPrijava_Click(object sender, EventArgs e)
        {
            otvoriPrijavu();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            logKorisnik = ssMaintsLogirani;
            staticPrijava = msMainmiPrijava;
            staticOdjava = msMainmiOdjava;
            staticUpravljanjeKorisnicima = msMainmiKorisnicima;
            onemoguceno();
            otvoriPrijavu();
            
        }

        private void msMainmiOdjava_Click(object sender, EventArgs e)
        {
            onemoguceno();
        }
        
        //Izlaz iz aplikacije
        private void msMainmiIzlaz_Click(object sender, EventArgs e)
        {
            provjaraIzlaza();
        }


        private void msMainmiKorisnicima_Click(object sender, EventArgs e)
        {
            frmUpravljanjeKorisnicima formaUpravljanje = new frmUpravljanjeKorisnicima();
            formaUpravljanje.MdiParent = this;
            formaUpravljanje.Show();
        }

        private void msMainmiAbout_Click(object sender, EventArgs e)
        {
            frmAbout formaOprogramu = new frmAbout();
            formaOprogramu.MdiParent = this;
            formaOprogramu.Show();
        }

        private void msMainmiUpute_Click(object sender, EventArgs e)
        {
            frmUpute formaUpute = new frmUpute();
            formaUpute.MdiParent = this;
            formaUpute.Show();
        }
        //-----------------------------------------------------------------
        public static void upisiUstatus(string tekst)
        {
            logKorisnik.Text = tekst;
        }

    }
}
