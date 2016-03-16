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
    public class EntityDistrito
    {
        private KeyDistrito key;
        private String nombre;
        private Int32 estado;

        public EntityDistrito()
        {

        }

        public EntityDistrito(
           Keys.KeyDistrito okey,
           String oNombre,
           Int32 oEstado)
        {
            this.key = okey;
            this.nombre = oNombre;
            this.estado = oEstado;
        }

        [DataMember]
        public KeyDistrito Key
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

        public static EntityDistrito Create(IDataReader fila)
        {
            return new EntityDistrito(
                Keys.KeyDistrito.Create(fila),
                DataCreator.CreateString(fila, "Nombre"),
                DataCreator.CreateInt32(fila, "Estado"));
        }

        public static EntityDistrito Empty
        {
            get
            {
                return new EntityDistrito(
                Keys.KeyDistrito.Empty,
                Parameters.Vacio,
                Parameters.UnoNegativo);
            }
        }
    }
}
