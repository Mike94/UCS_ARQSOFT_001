CREATE PROCEDURE [dbo].[usp_pedido_select]
(
 @IDPedido			   INT = NULL
,@IDEmpresa			   INT = 0
,@CodigoPedido VARCHAR(25) = ''
,@FechaPedido	  DATETIME = NULL
,@FechaPago		  DATETIME = NULL
,@FechaEntrega	  DATETIME = NULL
,@IDEncargado		   INT = ''
,@Estado		INT		= -1
)
AS
BEGIN

SELECT pe.IDPedido,
       pe.IDEmpresa,
	   pe.CodigoPedido,
	   pe.FechaPedido,
	   pe.FechaPago,
	   pe.FechaEntrega,
	   pe.IDEncargado,
	   pe.Estado
FROM   Pedidos pe
WHERE	(pe.IDPedido = @IDPedido OR @IDPedido IS NULL)
AND		(pe.IDEmpresa = @IDEmpresa OR @IDEmpresa IS NULL OR @IDEmpresa = 0)
AND		(pe.CodigoPedido = @CodigoPedido OR @CodigoPedido IS NULL OR CodigoPedido = '')
AND		(pe.FechaPedido = @FechaPedido OR @FechaPedido IS NULL)
AND		(pe.FechaPago = @FechaPago OR @FechaPago IS NULL)
AND		(pe.FechaEntrega= @FechaEntrega OR @FechaEntrega IS NULL)
AND		(pe.IDEncargado = @IDEncargado OR @IDEncargado IS NULL OR @IDEncargado = 0)
AND		(pe.Estado = @Estado OR @Estado IS NULL OR @Estado = -1)
END