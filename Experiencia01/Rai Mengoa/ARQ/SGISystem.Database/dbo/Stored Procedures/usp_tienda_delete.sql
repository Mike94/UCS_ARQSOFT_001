CREATE PROCEDURE [dbo].[usp_tienda_delete](
 @CodTienda CHAR(5) = ''
)
AS
BEGIN
  UPDATE dbo.Tienda
  SET Estado      = 0
  WHERE  
    CodTienda   = @CodTienda
END