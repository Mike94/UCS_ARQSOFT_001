using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityTipoEmpresa
    {
        private KeyTipoEmpresa key;
        private String nombreTipo;
        private Int32 estado;

        public EntityTipoEmpresa()
        {

        }

        public EntityTipoEmpresa(
           Keys.KeyTipoEmpresa okey,
           String oNombreTipo,
           Int32 oEstado)
        {
            this.key = okey;
            this.nombreTipo = oNombreTipo;
            this.estado= oEstado;
        }

        [DataMember]
        public KeyTipoEmpresa Key
        {
            get { return key; }
            set { key = value; }
        }

        [DataMember]
        public String NombreTipo
        {
            get { return nombreTipo; }
            set { nombreTipo = value; }
        }

        [DataMember]
        public Int32 Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public static EntityTipoEmpresa Create(IDataReader fila)
        {
            return new EntityTipoEmpresa(
                Keys.KeyTipoEmpresa.Create(fila),
                DataCreator.CreateString(fila, "NombreTipo"),
                DataCreator.CreateInt32(fila, "Estado"));
        }
 
        public static EntityTipoEmpresa Empty
        {
            get
            {
                return new EntityTipoEmpresa(
                Keys.KeyTipoEmpresa.Empty,
                Parameters.Vacio,
                Parameters.UnoNegativo);
            }
        }
    }
}
