using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityCargo
    {
        private KeyCargo key;
        private String nombreCargo;
        private String descripcion;
        private Int32 estado;

        public EntityCargo()
        {

        }

        public EntityCargo(
           Keys.KeyCargo okey,
           String oNombreCargo,
           String oDescripcion,
           Int32 oEstado)
        {
            this.key = okey;
            this.nombreCargo = oNombreCargo;
            this.descripcion = oDescripcion;
            this.estado= oEstado;
        }

        [DataMember]
        public KeyCargo Key
        {
            get { return key; }
            set { key = value; }
        }

        [DataMember]
        public String NombreCargo
        {
            get { return nombreCargo; }
            set { nombreCargo = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [DataMember]
        public Int32 Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public static EntityCargo Create(IDataReader fila)
        {
            return new EntityCargo(
                Keys.KeyCargo.Create(fila),
                DataCreator.CreateString(fila, "NombreCargo"),
                DataCreator.CreateString(fila, "Descripcion"),
                DataCreator.CreateInt32(fila, "Estado"));
        }


        public static EntityCargo Empty
        {
            get
            {
                return new EntityCargo(
                Keys.KeyCargo.Empty,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.UnoNegativo);
            }
        }
    }
}
