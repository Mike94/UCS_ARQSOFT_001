using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using SGISystem.Domain.Entities.Keys;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Pagination
{
    [DataContract]
    public class EntityDetallePedidoPaginacion : EntityDetallePedido
    {
        public EntityDetallePedidoPaginacion()
        {

        }

        public EntityDetallePedidoPaginacion(
            KeyDetallePedido oKey,
            int oCantidad,
            decimal oTotalBruto,
            decimal oRetencion,
            decimal oTotalNeto,
            int oEstado, 
            String oEstadoNombre,
            EntityPaginacion oEntityPaginacion)
        :base (
            oKey,
            oCantidad,
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

        public static EntityDetallePedidoPaginacion CreatePag(IDataReader fila)
        {
            return new EntityDetallePedidoPaginacion(
                 Keys.KeyDetallePedido.Create(fila),
                 DataCreator.CreateInt32(fila, "Cantidad"),
                 DataCreator.CreateDecimal(fila, "TotalBruto"),
                 DataCreator.CreateDecimal(fila, "Retencion"),
                 DataCreator.CreateDecimal(fila, "TotalNeto"),
                 DataCreator.CreateInt32(fila, "Estado"),
                 DataCreator.CreateString(fila, "EstadoNombre"),
                 null);
        }


        public static EntityDetallePedidoPaginacion EmptyPag
        {
            get
            {
                return new EntityDetallePedidoPaginacion(
                Keys.KeyDetallePedido.Empty,
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
