using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FrmGererMed : Form
    {
        private gsbrapports2021Entities lesDonnees;
        public FrmGererMed(gsbrapports2021Entities lesDonnees)
        {
            InitializeComponent();
            this.lesDonnees = lesDonnees;
            this.bdgFam.DataSource = lesDonnees.familles.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fam = this.cmbFam.Text;
        }

        private void FrmGererMed_Load(object sender, EventArgs e)
        {

        }
    }
}