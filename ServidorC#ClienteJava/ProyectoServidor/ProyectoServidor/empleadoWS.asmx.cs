using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProyectoServidor
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    
    public class empleadoWS : System.Web.Services.WebService
    {
        private empleadoDA acceso;

        public empleadoWS()
        {
            acceso = new empleadoDA();
        }

        [WebMethod]
        public BindingList<empleado> listarEmpleados()
        {
            BindingList<empleado> lista = 
                new BindingList<empleado>();
            lista = acceso.listarEmpleados();
            return lista;
        }
    }
}
