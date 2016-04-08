package controller;

import java.io.IOException;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import model.MateModel;

@WebServlet(name = "MateController", urlPatterns = {"/MateController"})
public class MateController extends HttpServlet {

  private MateModel mateModel;

  @Override
  public void init() throws ServletException {
    mateModel = new MateModel();
  }
  
  @Override
  protected void service(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
    // Datos
    int n1 = Integer.parseInt(request.getParameter("n1"));
    int n2 = Integer.parseInt(request.getParameter("n2"));
    // Proceso
    int suma = mateModel.sumar(n1, n2);
    // Reporte
    request.setAttribute("suma", suma);
    RequestDispatcher rd = request.getRequestDispatcher("index.jsp");
    rd.forward(request, response);
  }

}
