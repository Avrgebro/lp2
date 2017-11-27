using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    

    public class empleadoBL
    {
        private empleadoDA.empleadoWSClient acceso;

        public empleadoBL()
        {
            acceso = new empleadoDA.empleadoWSClient();

        }

        public BindingList<empleadoDA.empleado> listarEmpleados()
        {
            BindingList<empleadoDA.empleado> lista =
                new BindingList<empleadoDA.empleado>();
            lista = 
                new BindingList<empleadoDA.empleado>(
                    acceso.listarEmpleados());
            return lista;
        }

    }
}
