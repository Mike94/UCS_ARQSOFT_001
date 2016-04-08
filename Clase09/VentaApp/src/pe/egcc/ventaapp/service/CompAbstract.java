package pe.egcc.ventaapp.service;

import pe.egcc.ventaapp.dto.ItemDto;

/**
 *
 * @author Gustavo Coronel
 */
public abstract class CompAbstract {
  
  protected final double IGV = 0.18;
  protected final double SERVICIO = 0.10;
  
  public abstract ItemDto[] procesar(double total);
  
}
