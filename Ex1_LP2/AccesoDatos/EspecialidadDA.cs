using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using System.IO;

namespace AccesoDatos
{
    public class EspecialidadDA
    {

        public BindingList<Especialidad> GetEspecialidades()
        {
            FileStream arch = new FileStream("especialidades.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(arch);
            BindingList<Especialidad> ret = new BindingList<Especialidad>();

            while (true)
            {
                string codigo = reader.ReadLine();
                if (codigo == null) break;
                string nombre = reader.ReadLine();
                Especialidad e = new Especialidad(codigo, nombre);
                ret.Add(e);

            }

            reader.Close();
            arch.Close();
            return ret;
        }
    }
}
