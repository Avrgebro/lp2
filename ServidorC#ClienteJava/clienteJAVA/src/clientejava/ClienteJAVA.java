/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clientejava;

import java.util.ArrayList;

/**
 *
 * @author Freddy
 */
public class ClienteJAVA {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        EmpleadoWS ws = new EmpleadoWS();
        EmpleadoWSSoap com = ws.getEmpleadoWSSoap();
        
        ArrayList<Empleado> lista 
                = new ArrayList<Empleado>();
        lista.addAll(
        com.listarEmpleados().getEmpleado());
        
        for(int i=0; i<lista.size();i++){
            System.out.println(lista.get(i).getNombre());
        }
                
    }

    
    
    
}
