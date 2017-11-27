
package clientejava;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para anonymous complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="listarEmpleadosResult" type="{http://tempuri.org/}ArrayOfEmpleado" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "listarEmpleadosResult"
})
@XmlRootElement(name = "listarEmpleadosResponse")
public class ListarEmpleadosResponse {

    protected ArrayOfEmpleado listarEmpleadosResult;

    /**
     * Obtiene el valor de la propiedad listarEmpleadosResult.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfEmpleado }
     *     
     */
    public ArrayOfEmpleado getListarEmpleadosResult() {
        return listarEmpleadosResult;
    }

    /**
     * Define el valor de la propiedad listarEmpleadosResult.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfEmpleado }
     *     
     */
    public void setListarEmpleadosResult(ArrayOfEmpleado value) {
        this.listarEmpleadosResult = value;
    }

}
