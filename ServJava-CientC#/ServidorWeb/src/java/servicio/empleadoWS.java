package servicio;

import accesoDatos.empleadoDA;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import modelo.empleado;

/**
 *
 * @author Freddy
 */
@WebService(serviceName = "empleadoWS")
public class empleadoWS {

    private empleadoDA acceso;
    
    public empleadoWS(){
        acceso = new empleadoDA();
    }
    
    /**
     * This is a sample web service operation
     */
//    @WebMethod(operationName = "hello")
//    public String hello(@WebParam(name = "name") String txt) {
//        return "Hello " + txt + " !";
//    }
    
    @WebMethod(operationName = "listarEmpleados")
    public ArrayList<empleado> 
        listarEmpleados() {
        ArrayList<empleado> lista = acceso.listarEmpleados();
        return lista;
    }
}
