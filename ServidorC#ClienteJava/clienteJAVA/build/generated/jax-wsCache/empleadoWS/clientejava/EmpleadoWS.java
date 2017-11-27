
package clientejava;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "empleadoWS", targetNamespace = "http://tempuri.org/", wsdlLocation = "http://localhost:54122/empleadoWS.asmx?WSDL")
public class EmpleadoWS
    extends Service
{

    private final static URL EMPLEADOWS_WSDL_LOCATION;
    private final static WebServiceException EMPLEADOWS_EXCEPTION;
    private final static QName EMPLEADOWS_QNAME = new QName("http://tempuri.org/", "empleadoWS");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://localhost:54122/empleadoWS.asmx?WSDL");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        EMPLEADOWS_WSDL_LOCATION = url;
        EMPLEADOWS_EXCEPTION = e;
    }

    public EmpleadoWS() {
        super(__getWsdlLocation(), EMPLEADOWS_QNAME);
    }

    public EmpleadoWS(WebServiceFeature... features) {
        super(__getWsdlLocation(), EMPLEADOWS_QNAME, features);
    }

    public EmpleadoWS(URL wsdlLocation) {
        super(wsdlLocation, EMPLEADOWS_QNAME);
    }

    public EmpleadoWS(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, EMPLEADOWS_QNAME, features);
    }

    public EmpleadoWS(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public EmpleadoWS(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns EmpleadoWSSoap
     */
    @WebEndpoint(name = "empleadoWSSoap")
    public EmpleadoWSSoap getEmpleadoWSSoap() {
        return super.getPort(new QName("http://tempuri.org/", "empleadoWSSoap"), EmpleadoWSSoap.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns EmpleadoWSSoap
     */
    @WebEndpoint(name = "empleadoWSSoap")
    public EmpleadoWSSoap getEmpleadoWSSoap(WebServiceFeature... features) {
        return super.getPort(new QName("http://tempuri.org/", "empleadoWSSoap"), EmpleadoWSSoap.class, features);
    }

    /**
     * 
     * @return
     *     returns EmpleadoWSSoap
     */
    @WebEndpoint(name = "empleadoWSSoap12")
    public EmpleadoWSSoap getEmpleadoWSSoap12() {
        return super.getPort(new QName("http://tempuri.org/", "empleadoWSSoap12"), EmpleadoWSSoap.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns EmpleadoWSSoap
     */
    @WebEndpoint(name = "empleadoWSSoap12")
    public EmpleadoWSSoap getEmpleadoWSSoap12(WebServiceFeature... features) {
        return super.getPort(new QName("http://tempuri.org/", "empleadoWSSoap12"), EmpleadoWSSoap.class, features);
    }

    private static URL __getWsdlLocation() {
        if (EMPLEADOWS_EXCEPTION!= null) {
            throw EMPLEADOWS_EXCEPTION;
        }
        return EMPLEADOWS_WSDL_LOCATION;
    }

}
