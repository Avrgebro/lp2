using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCliente
{
    public partial class Form1 : Form
    {
        private empleadoBL logica;

        public Form1()
        {
            InitializeComponent();
            logica = new empleadoBL();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = 
                logica.listarEmpleados();
            
        }
    }
}
