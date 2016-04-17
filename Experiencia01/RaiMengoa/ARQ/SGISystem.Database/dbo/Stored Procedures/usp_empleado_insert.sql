CREATE PROCEDURE [dbo].[usp_empleado_insert]
(@IDEmpleado	  INT		   OUT
,@CodTienda		  CHAR(5)	   = ''
,@Nombres	      VARCHAR(200) = ''	
,@Apellidos		  VARCHAR(200) = ''
,@FechaNacimiento DATETIME	 = null
,@DNI		      VARCHAR(8)   = ''
,@IdCargo		  INT		 = null
,@Sexo			  CHAR(1)	 = ''
,@EstadoCivil	  CHAR(1)	 = ''
,@Estado		  INT		 = null)
AS
BEGIN

SELECT @IDEmpleado = (ISNULL(MAX(IDEmpleado), 0) + 1) FROM Empleados;

INSERT   Empleados
		(IDEmpleado
		,CodTienda
		,Nombres	
		,Apellidos	
		,FechaNacimiento	
		,DNI
		,IdCargo
		,Sexo		
		,EstadoCivil
		,Estado)
VALUES	
		(@IDEmpleado
		,@CodTienda
		,@Nombres	
		,@Apellidos
		,@FechaNacimiento
		,@DNI
		,@IdCargo
		,@Sexo		
		,@EstadoCivil
		,@Estado);
END