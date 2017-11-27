package accesoDatos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import modelo.empleado;

public class empleadoDA {
    public ArrayList<empleado> listarEmpleados(){
        ArrayList<empleado> lista = new ArrayList<empleado>();
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection(
                    "jdbc:mysql://50.62.209.188/LP2", "fpaz", "123456");
            Statement st = con.createStatement();
            String query = "SELECT * FROM EMPLEADO";
            ResultSet rs = st.executeQuery(query);
            while(rs.next()){
                empleado emp = new empleado();
                emp.setId(rs.getInt("ID_EMPLEADO"));
                emp.setNombre(rs.getString("NOMBRE"));
                emp.setApellido(rs.getString("APELLIDO"));
                emp.setEdad(rs.getInt("EDAD"));
                lista.add(emp);
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lista;
    }
}
