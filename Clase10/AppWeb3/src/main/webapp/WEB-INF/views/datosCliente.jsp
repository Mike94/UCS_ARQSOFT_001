<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
  <h1>DATOS DE UN CLIENTE</h1>
  <form method="post" action="datosCliente.htm">
    <p>Código: <input type="text" name="codigo" /></p>
    <p><input type="submit" value="Consultar" /></p>
  </form>
  <h2>REPORTE</h2>
  <p>Codigo: ${bean.codigo}</p>
  <p>Paterno: ${bean.paterno}</p>
  <p>Materno: ${bean.materno}</p>
  <p>Nombre: ${bean.nombre}</p>
  <p>DNI: ${bean.dni}</p>
  <p>Email: ${bean.email}</p>
  
  
</body>
</html>