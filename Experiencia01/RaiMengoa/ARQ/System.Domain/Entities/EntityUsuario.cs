using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityUsuario
    {
        private KeyUsuario _Key;
        private String _Usuario;
        private String _Clave;
        private Int32 _Estado;

        public EntityUsuario()
        {

        }

        public EntityUsuario(
           Keys.KeyUsuario okey,
           String oUsuario,
           String oClave,
           Int32 oEstado)
        {
            this._Key = okey;
            this._Usuario = oUsuario;
            this._Clave = oClave;
            this._Estado = oEstado;
        }

        [DataMember]
        public KeyUsuario Key
        {
            get { return _Key; }
            set { _Key = value; }
        }

        [DataMember]
        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        [DataMember]
        public String Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }

        [DataMember]
        public Int32 Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public static EntityUsuario Create(IDataReader fila)
        {
            return new EntityUsuario(
               Keys.KeyUsuario.Create(fila),
                DataCreator.CreateString(fila, "Usuario"),
                DataCreator.CreateString(fila, "Clave"),
                DataCreator.CreateInt32(fila, "Estado"));
        }

        
        public static EntityUsuario Empty
        {
            get
            {
                return new EntityUsuario(
                Keys.KeyUsuario.Empty,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Cero);
            }
        }
    }
}
