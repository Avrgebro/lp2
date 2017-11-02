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
using Modelo;
using System.IO;

namespace Vista
{   
    public partial class frmGestionAlumno : Form
    {
        Matricula mat;
        public frmGestionAlumno()
        {
            InitializeComponent();
            SetEstado(0);
            SemestreDA sda = new SemestreDA();
            cbEspecialidad.DataSource = getEsps();
            cbSemestre.DataSource = sda.GetSemestres();
            mat = new Matricula();

            try
            {
                FileStream arch = new FileStream("alumnos.dat", FileMode.Open, FileAccess.Read);
                arch.Close();
            }
            catch(Exception se)
            {
                FileStream arch = new FileStream("alumnos.dat", FileMode.Create);
                arch.Close();
            }
            
            

        }

        private BindingList<string> getEsps()
        {
            EspecialidadDA eda = new EspecialidadDA();
            BindingList<Especialidad> e = eda.GetEspecialidades();
            BindingList<string> ret = new BindingList<string>();
            foreach(Especialidad esp in e)
            {
                ret.Add(esp.Nombre);
            }

            return ret;
        }

        private void limpiarVentana()
        {
            mat = new Matricula();
            txtDNI.Text = "";
            txtNombreCompleto.Text = "";
            dtpNacimiento.Value = DateTime.Now;
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            txtTelefono.Text = "";
            //cbEspecialidad.selec = false;
            //cbBiblioteca.Enabled = false;
            //cbComedores.Enabled = false;
            //cbServicioDeportivo.Enabled = false;
            //cbSemestre.Enabled = false;
            
        }

        private void SetEstado(int e)
        {
            if(e == 0)//estado inicial
            {
                btnNuevo.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                txtDNI.Enabled = false;
                txtNombreCompleto.Enabled = false;
                dtpNacimiento.Enabled = false;
                rbMasculino.Enabled = false;
                rbFemenino.Enabled = false;
                txtTelefono.Enabled = false;
                cbEspecialidad.Enabled = false;
                cbBiblioteca.Enabled = false;
                cbComedores.Enabled = false;
                cbServicioDeportivo.Enabled = false;
                cbSemestre.Enabled = false;
                btnBuscarCurso.Enabled = false;
                btnEliminar2.Enabled = false;
                txtEmail.Enabled = false;
            }
            else if(e == 1)//estado nuevo
            {
                limpiarVentana();
                btnNuevo.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                txtDNI.Enabled = true;
                txtNombreCompleto.Enabled = true;
                dtpNacimiento.Enabled = true;
                rbMasculino.Enabled = true;
                rbFemenino.Enabled = true;
                txtTelefono.Enabled = true;
                cbEspecialidad.Enabled = true;
                cbBiblioteca.Enabled = true;
                cbComedores.Enabled = true;
                cbServicioDeportivo.Enabled = true;
                cbSemestre.Enabled = true;
                btnBuscarCurso.Enabled = true;
                btnEliminar2.Enabled = true;
                txtEmail.Enabled = true;
            }
            else if(e == 2)
            {
                limpiarVentana();
                btnNuevo.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                txtDNI.Enabled = false;
                txtNombreCompleto.Enabled = false;
                dtpNacimiento.Enabled = false;
                rbMasculino.Enabled = false;
                rbFemenino.Enabled = false;
                txtTelefono.Enabled = false;
                cbEspecialidad.Enabled = false;
                cbBiblioteca.Enabled = false;
                cbComedores.Enabled = false;
                cbServicioDeportivo.Enabled = false;
                cbSemestre.Enabled = false;
                btnBuscarCurso.Enabled = false;
                btnEliminar2.Enabled = false;
                txtEmail.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            SetEstado(1);
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            frmBusqCurso frmbc = new frmBusqCurso();
            if(frmbc.ShowDialog() == DialogResult.OK)
            {
                mat.Cursos.Add(frmbc.CursoSelec);
                dgvCursosMatriculados.DataSource = mat.Cursos;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarVentana();
            SetEstado(0);
        }

        private bool valido()
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("dni incorrecto", "", MessageBoxButtons.OK);
                return false;
            }
            if (txtNombreCompleto.Text == "")
            {
                MessageBox.Show("nombre incorrecto", "", MessageBoxButtons.OK);
                return false;
            }
            if (rbFemenino.Checked == false && rbMasculino.Checked == false)
            {
                MessageBox.Show("sexo no seleccionado", "", MessageBoxButtons.OK);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("email incorrecto", "", MessageBoxButtons.OK);
                return false;
            }

            if (txtTelefono.Text == "")
            {
                MessageBox.Show("telefono incorrecto", "", MessageBoxButtons.OK);
                return false;
            }
            if (mat.Cursos.Count == 0)
            {
                MessageBox.Show("No hay cursos registrados", "", MessageBoxButtons.OK);
                return false;
            }

            //ahora validamos la fecha del semestre
            /*string semestre = ""+mat.Fechanac.Year;
            System.Console.WriteLine(semestre);
            if (mat.Fechanac.Month >= 1 && mat.Fechanac.Month < 3) semestre = semestre + "-0";
            else if (mat.Fechanac.Month >= 3 && mat.Fechanac.Month < 7) semestre = semestre + "-1";
            else if (mat.Fechanac.Month >= 7 && mat.Fechanac.Month <=12) semestre = semestre + "-2";

            if (semestre != cbSemestre.Text)
            {
                System.Console.WriteLine(semestre);
                System.Console.WriteLine(mat.Fechanac.Year);
                System.Console.WriteLine(mat.Fechanac.Month);
                MessageBox.Show("No te puedes matricular en este semestre", "", MessageBoxButtons.OK);
                return false;
            }*/
            //El metodo YEAR y MONTH de date time siempre me devuelven uno, por lo que no se pudo terminar la comparacion.


            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //aca guardo en el archivo

            if (!valido())
            {
                //MessageBox.Show("Hay campos incorrectos", "", MessageBoxButtons.OK);
                return;
            }

            mat.Dni = txtDNI.Text;
            mat.Nombre = txtNombreCompleto.Text;
            mat.Fechanac = dtpNacimiento.Value;
            if(rbMasculino.Checked == true) { mat.Sexo = "Masculino"; }
            else { mat.Sexo = "Femenino"; }
            mat.Email = txtEmail.Text;
            mat.Telef = txtTelefono.Text;
            mat.Especialidad = cbEspecialidad.Text;

            mat.Permisos = 9;
            if(cbBiblioteca.Checked) { mat.Permisos += 100; }
            if (cbComedores.Checked) { mat.Permisos += 10; }
            if (cbServicioDeportivo.Checked) { mat.Permisos += 1; }

            AlumnoDA ada = new AlumnoDA();
            ada.GuardarAlumno(mat);
            MessageBox.Show("Registro Guardado con exito", "", MessageBoxButtons.OK);
            SetEstado(2);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaAlumno frmbc = new frmBusquedaAlumno();
        }
    }
}
