package pe.egcc.ventaapp.prueba;

import pe.egcc.ventaapp.dto.ItemDto;
import pe.egcc.ventaapp.service.BoletaService;
import pe.egcc.ventaapp.service.CompAbstract;
import pe.egcc.ventaapp.service.FacturaService;

/**
 *
 * @author Gustavo Coronel
 */
public class Prueba01 {

  public static void main(String[] args) {
    // Datos
    double total = 567.34;
    // Proceso
    CompAbstract comp = new FacturaService();
    ItemDto[] repo = comp.procesar(total);
    // Reporte
    for (ItemDto dto : repo) {
      System.out.println(dto.getConcepto() + " | " + dto.getValor());
    }
  }
  
}
