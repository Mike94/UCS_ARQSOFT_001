package pe.egcc.ventaapp.service;

/**
 *
 * @author Gustavo Coronel
 */
public final class CompFactory {

  private CompFactory() {
  }
  
  public static final String COMP_FACTURA = "FACTURA";
  public static final String COMP_BOLETA = "BOLETA";
  
  public static CompAbstract obtenerComp(String tipo){
    CompAbstract comp = null;
    switch(tipo){
      case COMP_FACTURA:
        comp = new FacturaService();
        break;
      case COMP_BOLETA:
        comp = new BoletaService();
        break;
    }
    return comp;
  }
  
  
  
}
