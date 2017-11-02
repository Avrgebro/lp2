using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Especialidad
    {
        private string _codigo;
        private string _nombre;

        public Especialidad(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
