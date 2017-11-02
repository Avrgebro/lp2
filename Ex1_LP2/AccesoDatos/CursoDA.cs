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
    public class CursoDA
    {
        public BindingList<Curso> GetCursos()
        {
            FileStream arch = new FileStream("cursos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(arch);
            BindingList<Curso> ret = new BindingList<Curso>();

            while (true)
            {
                string codigo = reader.ReadLine();
                if (codigo == null) break;
                string nombre = reader.ReadLine();
                Curso c = new Curso(codigo, nombre);
                ret.Add(c);

            }

            reader.Close();
            arch.Close();
            return ret;
        }
    }
}
