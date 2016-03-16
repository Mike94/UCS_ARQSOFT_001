CREATE PROCEDURE [dbo].[usp_detalle_pedido_delete]
(
 @IDPedido			INT		 = NULL
,@IDProducto		BIGINT	 = NULL
,@Cantidad			INT		 = NULL
,@TotalBruto		DECIMAL(18,2) = NULL
,@Retencion			DECIMAL(10,2) = NULL
,@TotalNeto			DECIMAL(18,2) = NULL
,@Estado			INT		= NULL
)
AS
BEGIN

UPDATE [dbo].[DetallePedidos]
   SET [Estado] = 0
 WHERE [IDPedido] = @IDPedido

END