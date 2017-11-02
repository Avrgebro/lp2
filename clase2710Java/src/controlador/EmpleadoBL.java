package controlador;

import accesoDatos.EmpleadoDA;
import java.util.ArrayList;
import modelo.Empleado;


public class EmpleadoBL {
    private EmpleadoDA accesoDatos;
    
    public EmpleadoBL(){
        accesoDatos = new EmpleadoDA();
    }
    
    public void registrarEmpleado(Empleado emp){
        accesoDatos.registrarEmpleado(emp);
    }
    
    public ArrayList<Empleado> listaEmpleados(){
        return accesoDatos.listarEmpleados();
    }
}
