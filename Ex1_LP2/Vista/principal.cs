using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
            
        }

        private void gestionDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionAlumno frmObj = new frmGestionAlumno();
            frmObj.MdiParent = this;
            frmObj.Show();
        }
    }
}
