package pe.ucs.ws;

import javax.ejb.EJB;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import pe.ucs.app.MateEjbRemote;

@WebService(serviceName = "WSMate")
public class WSMate {

  @EJB
  private MateEjbRemote mateEjb;

  @WebMethod(operationName = "sumar")
  public int sumar(@WebParam(name = "num1") int num1, 
          @WebParam(name = "num2") int num2){
    return mateEjb.sumar(num1, num2);
  }
  
}
