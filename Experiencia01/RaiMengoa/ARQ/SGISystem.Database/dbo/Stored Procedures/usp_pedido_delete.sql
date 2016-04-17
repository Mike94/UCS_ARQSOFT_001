CREATE PROCEDURE [dbo].[usp_pedido_delete]
(
 @IDPedido			   INT = NULL
)
AS
BEGIN

UPDATE dbo.Pedidos
   SET Estado = 0
 WHERE IDPedido = @IDPedido;

END