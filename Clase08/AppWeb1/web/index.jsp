<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>JSP Page</title>
  </head>
  <body>
    <h1>SUMA</h1>
    <form method="post" action="MateController">
      Número 1: <input type="text" name="n1"/><br/>
      Número 2: <input type="text" name="n2"/><br/>
      <input type="submit" value="Procesar"/>
    </form>
    
    <h2>RESULTADO</h2>
    <p>Suma es: <%= request.getAttribute("suma") %></p>
  </body>
</html>
