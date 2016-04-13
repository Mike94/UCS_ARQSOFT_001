<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<html>
<head>
<title>Home</title>
</head>
<body>
	<h1>SUMA</h1>
	<form method="post" action="sumar.htm">
		Número 1: <input type="text" name="n1" /><br /> 
		Número 2: <input type="text" name="n2" /><br /> 
		<input type="submit" value="Procesar" />
	</form>

	<h2>RESULTADO</h2>
	<p>Suma es: ${suma}</p>
</body>
</html>
