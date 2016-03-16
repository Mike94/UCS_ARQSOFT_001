using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyPedido
    {
        private Int32 idPedido;

        [DataMember]
        public Int32 IDPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        public KeyPedido()
        {

        }

        public KeyPedido(Int32 oIDPedido)
        {
            this.idPedido = oIDPedido;
        }

        public static KeyPedido Create(IDataReader row)
        {
            return new KeyPedido(
                DataCreator.CreateInt32(row, "IDPedido")
            );
        }

        public static KeyPedido Empty
        {
            get
            {
                return new KeyPedido(
                    Parameters.Cero);
            }
        }
    }
}
