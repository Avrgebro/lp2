using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProyectoServidor
{
    public class empleadoDA
    {
        public BindingList<empleado> listarEmpleados()
        {
            BindingList<empleado> lista = new BindingList<empleado>();
            String cadena = "server=50.62.209.188;" +
                "user=fpaz; password=123456; database=LP2;" +
                "port=3306";
            MySqlConnection conn = new MySqlConnection(cadena);
            conn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM EMPLEADO";
            comando.Connection = conn;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                empleado emp = new empleado();
                emp.Id = reader.GetInt32("ID_EMPLEADO");
                emp.Nombre = reader.GetString("NOMBRE");
                emp.Apellido = reader.GetString("APELLIDO");
                emp.Edad = reader.GetInt32("EDAD");
                lista.Add(emp);
            }
            conn.Close();
            return lista;
        }
    }
}