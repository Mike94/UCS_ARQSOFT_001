CREATE PROCEDURE [dbo].[usp_empleado_update]
(@IDEmpleado	  INT		
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
UPDATE dbo.Empleados
   SET CodTienda		= @CodTienda,
       Nombres			= @Nombres, 
       Apellidos		= @Apellidos, 
       FechaNacimiento  = @FechaNacimiento,
	   DNI				= @DNI,
	   IdCargo			= @IdCargo,
	   @Sexo			= @Sexo,
	   @EstadoCivil		= @EstadoCivil,
       Estado = @Estado
 WHERE IDEmpleado = @IDEmpleado;
END