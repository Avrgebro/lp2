using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Vista
{
    public partial class frmBusquedaAlumno : Form
    {
        public frmBusquedaAlumno()
        {
            InitializeComponent();

            AlumnoDA ada = new AlumnoDA();
            dataGridView1.DataSource = ada.GetAlumnos();

        }
    }
}
