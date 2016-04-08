package pe.egcc.ventaapp.prueba;

import pe.egcc.ventaapp.dto.ItemDto;
import pe.egcc.ventaapp.service.CompAbstract;
import pe.egcc.ventaapp.service.CompFactory;

/**
 *
 * @author Gustavo Coronel
 */
public class Prueba02 {

  public static void main(String[] args) {
    // Datos
    double total = 567.34;
    String tipo = CompFactory.COMP_FACTURA;
    // Proceso
    CompAbstract comp = CompFactory.obtenerComp(tipo);
    ItemDto[] repo = comp.procesar(total);
    // Reporte
    for (ItemDto dto : repo) {
      System.out.println(dto.getConcepto() + " | " + dto.getValor());
    }
  }
  
}
