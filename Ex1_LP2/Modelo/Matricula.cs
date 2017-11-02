using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class Matricula
    {
        private string _dni;
        private string _nombre;
        private DateTime _fechanac;
        private string _sexo;
        private string _email;
        private string _telef;
        private string _especialidad;
        private int _permisos;
        private string _semestre;
        private BindingList<Curso> _cursos;

        public Matricula(string dni, string nombre, DateTime fechanac, string sexo, string email, string telef, string especialidad, int permisos, string semestre, BindingList<Curso> cursos)
        {
            Dni = dni;
            Nombre = nombre;
            Fechanac = fechanac;
            Sexo = sexo;
            Email = email;
            Telef = telef;
            Especialidad = especialidad;
            Permisos = permisos;
            Semestre = semestre;
            Cursos = cursos;
        }

        public Matricula()
        {
            Cursos = new BindingList<Curso>();
        }

        public string Dni { get => _dni; set => _dni = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime Fechanac { get => _fechanac; set => _fechanac = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telef { get => _telef; set => _telef = value; }
        public string Especialidad { get => _especialidad; set => _especialidad = value; }
        public int Permisos { get => _permisos; set => _permisos = value; }
        public string Semestre { get => _semestre; set => _semestre = value; }
        public BindingList<Curso> Cursos { get => _cursos; set => _cursos = value; }
    }
}
