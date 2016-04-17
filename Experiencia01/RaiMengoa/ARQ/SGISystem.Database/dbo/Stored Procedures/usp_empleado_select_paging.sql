CREATE PROCEDURE [dbo].[usp_empleado_select_paging]
(@Nombres		 VARCHAR(200) = NULL
,@Estado         INT = -1
,@PageIndex		 INT = NULL
,@PageSize		 INT = NULL
,@TotalRows		 INT   OUT)
AS
BEGIN
SET @TotalRows = (SELECT ISNULL(COUNT(1),0) FROM Empleados AS Emp 
				   LEFT JOIN Cargo car
				   ON		(Emp.IdCargo = car.IdCargo)
				   LEFT JOIN Tienda ti
				   ON		(Emp.CodTienda = ti.CodTienda)
				   WHERE 	(@Nombres IS NULL OR Emp.Nombres  LIKE '%' + @Nombres + '%' )
				   AND     (@Estado IS NULL OR @Estado = -1 OR @Estado = Emp.Estado));

SELECT   Fila
		,IDEmpleado
		,CodTienda
		,Nombres
		,Apellidos
		,FechaNacimiento
		,DNI
		,IdCargo
		,Sexo
		,EstadoCivil
		,Estado
		,SexoNombre
		,EstadoCivilNombre
		,EstadoNombre
		,NombreCargo
		,NombreTienda
FROM	(
		SELECT   ROW_NUMBER() OVER(ORDER BY IDEmpleado ASC) AS Fila
				,Emp.IDEmpleado
				,Emp.CodTienda
				,Emp.Nombres
				,Emp.Apellidos
				,Emp.FechaNacimiento
				,Emp.DNI
				,Emp.IdCargo
				,Emp.Sexo
				,Emp.EstadoCivil
				,Emp.Estado
				,(CASE 
           			WHEN Emp.Sexo = 'M' THEN 'Masculino'
					WHEN Emp.Sexo = 'F' THEN 'Femenino'
           			ELSE ''
				   END) AS SexoNombre
				,(CASE 
           			WHEN Emp.EstadoCivil = 'S' THEN 'Soltero(a)'
					WHEN Emp.EstadoCivil = 'C' THEN 'Casado(a)'
					WHEN Emp.EstadoCivil = 'V' THEN 'Viudo(a)'
					WHEN Emp.EstadoCivil = 'D' THEN 'Divorciado(a)'
           			ELSE ''
				   END) AS EstadoCivilNombre
				,(CASE 
           			WHEN Emp.Estado = 1 THEN 'Activo'
					WHEN Emp.Estado = 0 THEN 'Inactivo'
           			ELSE ''
				   END) AS EstadoNombre
				,car.NombreCargo
				,ti.NombreTienda
		FROM	Empleados AS Emp 
		LEFT JOIN Cargo car
		ON		(Emp.IdCargo = car.IdCargo)
		LEFT JOIN Tienda ti
		ON		(Emp.CodTienda = ti.CodTienda)
		WHERE 	(@Nombres IS NULL OR Emp.Nombres  LIKE '%' + @Nombres + '%' )
		AND     (@Estado IS NULL OR @Estado = -1 OR @Estado = Emp.Estado)) AS T_Employee
WHERE Fila BETWEEN (@PageIndex) * @PageSize + 1 AND (@PageIndex + 1) * @PageSize;

END
GO