package pe.egcc.appweb3.controller;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;

import pe.egcc.appweb3.service.MateService;

/**
 * Handles requests for the application home page.
 */
@Controller 
public class HomeController {
	
  @Autowired
  private MateService mateService;

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
	
	
	
	
}
