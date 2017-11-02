using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.ComponentModel;

namespace AccesoDatos
{
    public class AlumnoDA
    {
        public void GuardarAlumno(Matricula m)
        {
            FileStream arch = new FileStream("alumnos.dat", FileMode.Append, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(arch, m);
            }
            catch(Exception se)
            {
                arch.Close();
            }
            arch.Close();
        }

        public BindingList<Matricula> GetAlumnos()
        {
            BindingList<Matricula> ret = new BindingList<Matricula>();
            FileStream arch = new FileStream("alumnos.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            while (true)
            {
                Matricula m;
                try { m = (Matricula)formatter.Deserialize(arch); }
                catch (Exception se) { break; }
                ret.Add(m);
            }
            arch.Close();
            return ret;
        }
    }
}
