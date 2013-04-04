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
    public partial class frmUpravljanjeDodaj : Form
    {
        public frmUpravljanjeDodaj()
        {
            InitializeComponent();
        }

        private void frmUpravljanjeDodaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql25907DataSet.prava' table. You can move, or remove it, as needed.
            this.pravaTableAdapter.Fill(this.sql25907DataSet.prava);
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
