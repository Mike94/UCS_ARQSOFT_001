CREATE PROCEDURE [dbo].[usp_detalle_pedido_insert]
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

INSERT INTO dbo.DetallePedidos
           (IDPedido
           ,IDProducto
           ,Cantidad
           ,TotalBruto
           ,Retencion
           ,TotalNeto
           ,Estado)
     VALUES
           (@IDPedido
           ,@IDProducto
           ,@Cantidad
           ,@TotalBruto
           ,@Retencion
           ,@TotalNeto
           ,@Estado);

END