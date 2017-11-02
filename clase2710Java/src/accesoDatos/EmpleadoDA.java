package accesoDatos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import modelo.Empleado;

public class EmpleadoDA {
    
    public void registrarEmpleado(Empleado e){
        try{
            //Registro del Driver
            Class.forName("com.mysql.jdbc.Driver");
            
            Connection con = DriverManager.getConnection
        ("jdbc:mysql://50.62.209.188/LP2", "fpaz", "123456");
            
            Statement sentencia = con.createStatement();
            
            String instruccion = "INSERT INTO EMPLEADO(ID,Nombres,Apellidos)"
                    + " values("+e.getID()+",'"+e.getNombres()+
                    "','"+e.getApellidos()+"')";
            
            sentencia.executeUpdate(instruccion);
            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    
    public ArrayList<Empleado> listarEmpleados(){
         ArrayList<Empleado> listaEmpleados = new ArrayList<Empleado>();
        try{
           
            //Registro del Driver
            Class.forName("com.mysql.jdbc.Driver");
            
            Connection con = DriverManager.getConnection
        ("jdbc:mysql://50.62.209.188/LP2", "fpaz", "123456");
            
            Statement sentencia = con.createStatement();
            
            String instruccion = "SELECT * FROM EMPLEADO";
            
            ResultSet rs = sentencia.executeQuery(instruccion);
            
            while(rs.next()){
                Empleado emp = new Empleado();
                emp.setID(rs.getInt("ID"));
                emp.setNombres(rs.getString("Nombres"));
                emp.setApellidos(rs.getString("Apellidos"));
                listaEmpleados.add(emp);
            }
            
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return listaEmpleados;
    }
    
    public void actualizarEmpleado(){}
    
    public void eliminarEmpleado(){}
}
