using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2710
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "server=50.62.209.188;" +
                "user=fpaz;" +
                "database=LP2;port=3306;" +
                "password=123456;";

            MySqlConnection conn = 
                new MySqlConnection(url);
            conn.Open();
            System.Console.WriteLine("Conexion exitosa");

            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM EMPLEADO";
            //cmd.CommandText = "INSERT INTO EMPLEADO(ID,Nombres,Apellidos) values (6,'Alejandro','Bello')";
            cmd.Connection = conn;
            //cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("ID");
                String nombre = reader.GetString("Nombres");
                String apellidos = reader.GetString("Apellidos");

                System.Console.WriteLine(id + " " + nombre + " " + apellidos);
            }


            conn.Close();
            System.Console.Read();

        }
    }
}
