-- usp_empleado_select @Nombres = 'Emp'
CREATE PROCEDURE [dbo].[usp_empleado_select]
(@IDEmpleado	  INT		   = NULL
,@CodTienda		  CHAR(5)	   = NULL
,@Nombres	      VARCHAR(200) = NULL	
,@Apellidos		  VARCHAR(200) = NULL
,@FechaNacimiento DATETIME	   = NULL
,@DNI		      VARCHAR(8)   = NULL
,@IdCargo		  INT		   = NULL
,@Sexo			  CHAR(1)	   = NULL
,@EstadoCivil	  CHAR(1)	   = NULL
,@Estado		  INT		   = NULL)
AS
BEGIN
SELECT   Emp.IDEmpleado
		,Emp.CodTienda
		,Emp.Nombres
		,Emp.Apellidos
		,Emp.FechaNacimiento
		,Emp.DNI
		,Emp.IdCargo
		,Emp.Sexo
		,Emp.EstadoCivil
		,Emp.Estado
FROM	Empleados AS Emp 
WHERE	(@IDEmpleado IS NULL OR @IDEmpleado = Emp.IDEmpleado OR @IDEmpleado = -1 )
AND 	(@CodTienda = '' OR @CodTienda IS NULL OR Emp.CodTienda LIKE '%' + @CodTienda + '%' )
AND 	(@Nombres = '' OR @Nombres IS NULL OR Emp.Nombres  LIKE '%' + @Nombres + '%' )
AND 	(@Apellidos = '' OR @Apellidos IS NULL OR Emp.Apellidos LIKE '%' + @Apellidos+ '%' )
AND 	(@FechaNacimiento IS NULL OR @FechaNacimiento = Emp.FechaNacimiento)
AND 	(@IdCargo = 0 OR @IdCargo IS NULL OR @IdCargo = Emp.IdCargo)
AND 	(@Sexo = '' OR @Sexo IS NULL OR @Sexo = Emp.Sexo)
AND 	(@EstadoCivil = '' OR @EstadoCivil IS NULL OR @EstadoCivil = Emp.EstadoCivil)
AND 	(@Estado = -1 OR @Estado IS NULL OR @Estado = Emp.Estado)
END