package pe.egcc.appweb4.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;

import pe.egcc.appweb4.domain.Cliente;
import pe.egcc.appweb4.service.EurekaService;
import pe.egcc.appweb4.service.MateService;

/**
 * Handles requests for the application home page.
 */
@Controller 
public class HomeController {
	
  @Autowired
  private MateService mateService;
  
  @Autowired
  private EurekaService eurekaService;

	@RequestMapping(value = "/", method = RequestMethod.GET)
	public String home() {
		return "home";
	}
	
	@RequestMapping(value = "/sumar.htm", method = RequestMethod.POST)
	public String sumar(
	    @RequestParam("n1") int num1,
	    @RequestParam("n2") int num2,
	    Model model) {
	  int suma = mateService.sumar(num1, num2);
	  model.addAttribute("suma", suma);
	  return "home";
	}
	
	
	@RequestMapping(value = "/datosCliente.htm", method = RequestMethod.GET)
  public String datosCliente() {
    return "datosCliente";
  }
	
	@RequestMapping(value = "/datosCliente.htm", method = RequestMethod.POST)
  public String datosCliente( 
      @RequestParam("codigo") String codigo, Model model) {

	  Cliente bean = eurekaService.conCliente(codigo); 
	  model.addAttribute("bean",bean);
	  
	  return "datosCliente";
  }
	
}
