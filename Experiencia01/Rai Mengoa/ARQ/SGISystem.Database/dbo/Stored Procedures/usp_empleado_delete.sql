CREATE PROCEDURE [dbo].[usp_empleado_delete]
(@IDEmpleado	  INT)
AS
BEGIN
UPDATE dbo.Empleados
   SET Estado = 0
 WHERE IDEmpleado = @IDEmpleado;
END