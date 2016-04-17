using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyDetallePedido
    {
        private Int32 idPedido;
        private Int32 idProducto;

        [DataMember]
        public Int32 IDPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        [DataMember]
        public Int32 IDProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public KeyDetallePedido()
        {

        }

        public KeyDetallePedido
            (
            Int32 oIdPedido,
            Int32 oIdProducto
            )
        {
            this.idPedido = oIdPedido;
            this.idProducto = oIdProducto;
        }

        public static KeyDetallePedido Create(IDataReader row)
        {
            return new KeyDetallePedido(
                DataCreator.CreateInt32(row, "IDPedido"),
                DataCreator.CreateInt32(row, "IDProducto")
            );
        }

        public static KeyDetallePedido Empty
        {
            get
            {
                return new KeyDetallePedido(
                    Parameters.Cero,
                    Parameters.Cero);
            }
        }
    }
}
