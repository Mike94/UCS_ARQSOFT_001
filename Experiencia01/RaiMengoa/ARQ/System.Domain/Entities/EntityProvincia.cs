using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityProvincia
    {
        private KeyProvincia key;
        private String nombre;
        private Int32 estado;

        public EntityProvincia()
        {

        }

        public EntityProvincia(
           Keys.KeyProvincia okey,
           String oNombre,
           Int32 oEstado)
        {
            this.key = okey;
            this.nombre = oNombre;
            this.estado = oEstado;
        }

        [DataMember]
        public KeyProvincia Key
        {
            get { return key; }
            set { key = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public Int32 Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public static EntityProvincia Create(IDataReader fila)
        {
            return new EntityProvincia(
                Keys.KeyProvincia.Create(fila),
                DataCreator.CreateString(fila, "Nombre"),
                DataCreator.CreateInt32(fila, "Estado"));
        }

        public static EntityProvincia Empty
        {
            get
            {
                return new EntityProvincia(
                Keys.KeyProvincia.Empty,
                Parameters.Vacio,
                Parameters.UnoNegativo);
            }
        }
    }
}
