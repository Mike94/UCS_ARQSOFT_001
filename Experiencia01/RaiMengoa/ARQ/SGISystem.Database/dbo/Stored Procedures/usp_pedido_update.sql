CREATE PROCEDURE [dbo].[usp_pedido_update]
(
 @IDPedido			   INT = NULL
,@IDEmpresa			   INT = NULL
,@CodigoPedido VARCHAR(25) = NULL
,@FechaPedido	  DATETIME = NULL
,@FechaPago		  DATETIME = NULL
,@FechaEntrega	  DATETIME = NULL
,@IDEncargado		   INT = NULL
,@TotalBruto DECIMAL(18,2) = NULL
,@Retencion DECIMAL(10,2) = NULL
,@TotalNeto DECIMAL(18,2) = NULL
,@Estado		INT		= NULL
)
AS
BEGIN

UPDATE dbo.Pedidos
   SET IDEmpresa = @IDEmpresa
      ,CodigoPedido = @CodigoPedido
      ,FechaPedido = @FechaPedido
      ,FechaPago = @FechaPago
      ,FechaEntrega = @FechaEntrega
      ,IDEncargado = @IDEncargado
      ,TotalBruto = @TotalBruto
      ,Retencion = @Retencion
      ,TotalNeto = @TotalNeto
      ,Estado = @Estado
 WHERE IDPedido = @IDPedido;

END