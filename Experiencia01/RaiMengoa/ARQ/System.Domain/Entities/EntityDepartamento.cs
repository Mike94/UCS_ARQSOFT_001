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
    public class EntityDepartamento
    {
        private KeyDepartamento key;
        private String nombre;
        private Int32 estado;

        public EntityDepartamento()
        {

        }

        public EntityDepartamento(
           Keys.KeyDepartamento okey,
           String oNombre,
           Int32 oEstado)
        {
            this.key = okey;
            this.nombre = oNombre;
            this.estado = oEstado;
        }

        [DataMember]
        public KeyDepartamento Key
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

        public static EntityDepartamento Create(IDataReader fila)
        {
            return new EntityDepartamento(
                Keys.KeyDepartamento.Create(fila),
                DataCreator.CreateString(fila, "Nombre"),
                DataCreator.CreateInt32(fila, "Estado"));
        }

        public static EntityDepartamento Empty
        {
            get
            {
                return new EntityDepartamento(
                Keys.KeyDepartamento.Empty,
                Parameters.Vacio,
                Parameters.UnoNegativo);
            }
        }
    }
}
