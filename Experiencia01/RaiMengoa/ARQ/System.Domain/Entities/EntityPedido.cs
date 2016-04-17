using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using SGISystem.Domain.Entities.Keys;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityPedido
    {
       private KeyPedido key;
       private Int32 idEmpresa;
	   private String codigoPedido;
	   private DateTime fechaPedido;
	   private DateTime fechaPago;
	   private DateTime fechaEntrega;
	   private Int32 idEncargado;
	   private Decimal totalBruto;
	   private Decimal retencion;
	   private Decimal totalNeto;
	   private Int32 estado;

       public EntityPedido()
       {

       }

       public EntityPedido(
           KeyPedido oKey,
           int oIdEmpresa,
           string oCodigoPedido,
           DateTime oFechaPedido,
           DateTime oFechaPago,
           DateTime oFechaEntrega,
           int oIdEncargado,
           decimal oTotalBruto,
           decimal oRetencion,
           decimal oTotalNeto,
           int oEstado)
       {
           this.key = oKey;
           this.idEmpresa = oIdEmpresa;
           this.codigoPedido = oCodigoPedido;
           this.fechaPedido = oFechaPedido;
           this.fechaPago = oFechaPago;
           this.fechaEntrega = oFechaEntrega;
           this.idEncargado = oIdEncargado;
           this.totalBruto = oTotalBruto;
           this.retencion = oRetencion;
           this.totalNeto = oTotalNeto;
           this.estado = oEstado;
       }

       [DataMember]
       public KeyPedido Key
       {
           get { return key; }
           set { key = value; }
       }
      
       [DataMember]
       public Int32 IDEmpresa
       {
           get { return idEmpresa; }
           set { idEmpresa = value; }
       }

       [DataMember]
       public String CodigoPedido
       {
           get { return codigoPedido; }
           set { codigoPedido = value; }
       }

       [DataMember]
       public DateTime FechaPedido
       {
           get { return fechaPedido; }
           set { fechaPedido = value; }
       }

       [DataMember]
       public DateTime FechaPago
       {
          get { return fechaPago; }
          set { fechaPago = value; }
       }

       [DataMember]
       public DateTime FechaEntrega
       {
          get { return fechaEntrega; }
          set { fechaEntrega = value; }
       }

       [DataMember]
       public Int32 IDEncargado
       {
          get { return idEncargado; }
          set { idEncargado = value; }
       }

       [DataMember]
       public Decimal TotalBruto
       {
          get { return totalBruto; }
          set { totalBruto = value; }
       }

       [DataMember]
       public Decimal Retencion
       {
          get { return retencion; }
          set { retencion = value; }
       }

       [DataMember]
       public Decimal TotalNeto
       {
          get { return totalNeto; }
          set { totalNeto = value; }
       }

       [DataMember]
       public Int32 Estado
       {
          get { return estado; }
          set { estado = value; }
       }

       public static EntityPedido Create(IDataReader fila)
       {
           return new EntityPedido(
                Keys.KeyPedido.Create(fila),
                DataCreator.CreateInt32(fila, "IDEmpresa"),
                DataCreator.CreateString(fila, "CodigoPedido"),
                DataCreator.CreateDatetime(fila, "FechaPedido"),
                DataCreator.CreateDatetime(fila, "FechaPago"),
                DataCreator.CreateDatetime(fila, "FechaEntrega"),
                DataCreator.CreateInt32(fila, "IDEncargado"),
                DataCreator.CreateDecimal(fila, "TotalBruto"),
                DataCreator.CreateDecimal(fila, "Retencion"),
                DataCreator.CreateDecimal(fila, "TotalNeto"),
                DataCreator.CreateInt32(fila, "Estado"));
       }


       public static EntityPedido Empty
       {
           get
           {
               return new EntityPedido(
               Keys.KeyPedido.Empty,
               Parameters.Cero,
               Parameters.Vacio,
               Parameters.DtUnoUnoUno,
               Parameters.DtUnoUnoUno,
               Parameters.DtUnoUnoUno,
               Parameters.Cero,
               Parameters.Cero,
               Parameters.Cero,
               Parameters.Cero,
               Parameters.UnoNegativo);
           }
       }

    }
}
