package pe.ucs.app.servlets;

import java.io.IOException;
import java.io.PrintWriter;
import javax.ejb.EJB;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import pe.ucs.app.MateEjbRemote;

/**
 *
 * @author Docente
 */
@WebServlet(name = "Sumar", urlPatterns = {"/Sumar"})
public class Sumar extends HttpServlet {

  @EJB
  private MateEjbRemote mateEjb;

  
  
  @Override
  protected void service(HttpServletRequest request, 
          HttpServletResponse response) throws ServletException, IOException {
  
    // Datos
    int n1 = Integer.parseInt(request.getParameter("n1"));
    int n2 = Integer.parseInt(request.getParameter("n2"));
    
    // Proceso
    int suma = mateEjb.sumar(n1, n2);
    
    // Envio de respuesta
    request.setAttribute("n1", n1);
    request.setAttribute("n2", n2);
    request.setAttribute("suma", suma);
    RequestDispatcher rd = request.getRequestDispatcher("suma.jsp");
    rd.forward(request, response);
  }

  
  
}
