package pe.egcc.appweb4.dao.impl;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Repository;

import pe.egcc.appweb4.dao.espec.EurekaDaoEspec;
import pe.egcc.appweb4.dao.mapper.ClienteMapper;
import pe.egcc.appweb4.domain.Cliente;

@Repository
public class EurekaDaoImpl implements EurekaDaoEspec {
  
  @Autowired
  private JdbcTemplate jdbcTemplate;

  @Override
  public Cliente conCliente(String codigo) {
    Cliente bean;
    String sql = "select chr_cliecodigo, vch_cliepaterno, "
        + "vch_cliematerno, vch_clienombre, chr_cliedni, "
        + "vch_clieciudad, vch_cliedireccion, vch_clietelefono, "
        + "vch_clieemail from cliente where chr_cliecodigo = ?";
    Object[] args = {codigo};
    bean = jdbcTemplate.queryForObject(sql, args, new ClienteMapper());
    return bean;
  }

}
