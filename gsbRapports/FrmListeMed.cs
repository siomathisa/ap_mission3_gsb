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
    public partial class FrmListeMed : Form
    {
        private gsbrapports2021Entities lesDonnees;
        public FrmListeMed(gsbrapports2021Entities lesDonnees)
        {
            InitializeComponent();
            this.lesDonnees = lesDonnees;
        }

        private void FrmListeMed_Load(object sender, EventArgs e)
        {

        }
    }
}
