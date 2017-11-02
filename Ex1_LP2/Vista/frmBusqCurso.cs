using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using AccesoDatos;

namespace Vista
{
    public partial class frmBusqCurso : Form
    {
        Curso _cursoSelec;
        public frmBusqCurso()
        {
            
            InitializeComponent();
            CursoDA cda = new CursoDA();
            dgvCursos.DataSource = cda.GetCursos();
        }

        public Curso CursoSelec { get => _cursoSelec; set => _cursoSelec = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvCursos.CurrentRow == null)
            {
                return;
            }

            CursoSelec = (Curso)dgvCursos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;


        }
    }
}
