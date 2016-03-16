using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using SGISystem.Domain.Entities.Keys;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Pagination
{
    [DataContract]
    public class EntityPedidoPaginacion : EntityPedido
    {
        public EntityPedidoPaginacion()
        {

        }

        public EntityPedidoPaginacion(
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
           int oEstado,
           String oEstadoNombre,
           EntityPaginacion oEntityPaginacion)
          :base(
              oKey,
              oIdEmpresa,
              oCodigoPedido,
              oFechaPedido,
              oFechaPago,
              oFechaEntrega,
              oIdEncargado,
              oTotalBruto,
              oRetencion,
              oTotalNeto,
              oEstado
            )
       {
           this.entityPaginacion = oEntityPaginacion;
           this.estadoNombre = oEstadoNombre;
       }

        private EntityPaginacion entityPaginacion;

        [DataMember]
        public EntityPaginacion EntityPaginacion
        {
            get { return entityPaginacion; }
            set { entityPaginacion = value; }
        }

        private String estadoNombre;

        [DataMember]
        public String EstadoNombre
        {
            get { return estadoNombre; }
            set { estadoNombre = value; }
        }

        public static EntityPedidoPaginacion CreatePag(IDataReader fila)
        {
            return new EntityPedidoPaginacion(
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
                 DataCreator.CreateInt32(fila, "Estado"),
                 DataCreator.CreateString(fila, "EstadoNombre"),
                 null);
        }


        public static EntityPedidoPaginacion EmptyPag
        {
            get
            {
                return new EntityPedidoPaginacion(
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
                Parameters.UnoNegativo,
                Parameters.Vacio,
                null);
            }
        }

    }
}
