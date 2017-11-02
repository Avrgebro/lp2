package clase2710;
import java.sql.*;
import java.util.HashSet;
import java.util.Set;
import modelo.Empleado;
public class Clase2710 {
    public static void main(String[] args) {
        try{
            //Registro del Driver
            Class.forName("com.mysql.jdbc.Driver");
            
            Connection con = DriverManager.getConnection
        ("jdbc:mysql://50.62.209.188/LP2", "fpaz", "123456");
            
            System.out.println("Se ha realizado la conexion con la BD");
            
            Statement sentencia = con.createStatement();
            
            Empleado e = new Empleado();
            e.setID(2);
            e.setNombres("Arturo");
            e.setApellidos("Oncevay");
            
            
            
//            String instruccion = "INSERT INTO EMPLEADO(ID,Nombres,Apellidos)"
//                    + " values("+e.getID()+",'"+e.getNombres()+
//                    "','"+e.getApellidos()+"')";
//            
//            sentencia.executeUpdate(instruccion);

                String instruccion = "SELECT * FROM EMPLEADO";
                
            ResultSet rs = sentencia.executeQuery(instruccion);
            
            while(rs.next()){
                Empleado emp = new Empleado();
                emp.setID(rs.getInt("ID"));
                emp.setNombres(rs.getString("Nombres"));
                emp.setApellidos(rs.getString("Apellidos"));
                System.out.println(emp);
            }
            
            
            con.close();

        }catch(Exception e){
            System.out.println(e.getMessage());
        }
    }
}
