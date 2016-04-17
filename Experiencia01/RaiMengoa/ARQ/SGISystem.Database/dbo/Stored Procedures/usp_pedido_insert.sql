CREATE PROCEDURE [dbo].[usp_pedido_insert]
(
 @IDPedido				  INT OUT
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

SELECT @IDPedido = (ISNULL(MAX(IDPedido), 0) + 1) FROM Pedidos;

INSERT INTO dbo.Pedidos
           (IDPedido
           ,IDEmpresa
           ,CodigoPedido
           ,FechaPedido
           ,FechaPago
           ,FechaEntrega
           ,IDEncargado
           ,TotalBruto
           ,Retencion
           ,TotalNeto
           ,Estado)
     VALUES
           (@IDPedido
           ,@IDEmpresa
           ,@CodigoPedido
           ,@FechaPedido
           ,@FechaPago
           ,@FechaEntrega
           ,@IDEncargado
           ,@TotalBruto
           ,@Retencion
           ,@TotalNeto
           ,@Estado)
END