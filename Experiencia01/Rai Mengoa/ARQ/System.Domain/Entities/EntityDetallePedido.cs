using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using SGISystem.Domain.Entities.Keys;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityDetallePedido
    {
        private KeyDetallePedido key;
        private Int32 cantidad;
        private Decimal totalBruto;
        private Decimal retencion;
        private Decimal totalNeto;
        private Int32 estado;

        public EntityDetallePedido()
        {

        }

        public EntityDetallePedido(
            KeyDetallePedido oKey,
            int oCantidad,
            decimal oTotalBruto,
            decimal oRetencion,
            decimal oTotalNeto,
            int oEstado)
        {
            this.key = oKey;
            this.cantidad = oCantidad;
            this.totalBruto = oTotalBruto;
            this.retencion = oRetencion;
            this.totalNeto = oTotalNeto;
            this.estado = oEstado;
        }

        [DataMember]
        public KeyDetallePedido Key
        {
            get { return key; }
            set { key = value; }
        }

        [DataMember]
        public Int32 Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
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

        public static EntityDetallePedido Create(IDataReader fila)
        {
            return new EntityDetallePedido(
                 Keys.KeyDetallePedido.Create(fila),
                 DataCreator.CreateInt32(fila, "Cantidad"),
                 DataCreator.CreateDecimal(fila, "TotalBruto"),
                 DataCreator.CreateDecimal(fila, "Retencion"),
                 DataCreator.CreateDecimal(fila, "TotalNeto"),
                 DataCreator.CreateInt32(fila, "Estado"));
        }


        public static EntityDetallePedido Empty
        {
            get
            {
                return new EntityDetallePedido(
                Keys.KeyDetallePedido.Empty,
                Parameters.Cero,
                Parameters.Cero,
                Parameters.Cero,
                Parameters.Cero,
                Parameters.UnoNegativo);
            }
        }

    }
}