using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoServidor
{
    public class empleado
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private int _edad;

        public empleado()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Edad { get => _edad; set => _edad = value; }
    }
}