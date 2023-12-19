using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FrmMenu : Form
    {
        private gsbrapports2021Entities lesDonnees;
        public FrmMenu()
        {
            this.InitializeComponent();
            this.lesDonnees = new gsbrapports2021Entities();   
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGererMed f = new FrmGererMed(this.lesDonnees);
            f.MdiParent = this;
            f.Show();
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeMed f = new FrmListeMed(this.lesDonnees);
            f.MdiParent = this;
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
