using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyUsuario
    {
        private Int32 _IDUsuario;

        [DataMember]
        public Int32 IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        public KeyUsuario()
        {

        }

        public KeyUsuario(Int32 pIDUsuario)
        {
            this._IDUsuario = pIDUsuario;
        }


        public static KeyUsuario Create(IDataReader fila)
        {
            return new KeyUsuario(
                DataCreator.CreateInt32(fila, "IDUsuario")
            );
        }

        
        public static KeyUsuario Empty
        {
            get
            {
                return new KeyUsuario(
                    Parameters.Cero);
            }
        }
    }
}
