using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class SemestreDA
    {
        public BindingList<string> GetSemestres()
        {
            FileStream arch = new FileStream("semestres.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(arch);
            BindingList<string> ret = new BindingList<string>();

            while (true)
            {
                string semestre = reader.ReadLine();
                if (semestre == null) break;
                ret.Add(semestre);

            }

            reader.Close();
            arch.Close();
            return ret;
        }
    }
}
