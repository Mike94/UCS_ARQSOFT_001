package pe.egcc.appweb4.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import pe.egcc.appweb4.dao.espec.EurekaDaoEspec;
import pe.egcc.appweb4.domain.Cliente;

@Service
public class EurekaService {

  @Autowired
  private EurekaDaoEspec eurekaDaoImpl;
  
  public Cliente conCliente(String codigo){
    return eurekaDaoImpl.conCliente(codigo);
  }
}
