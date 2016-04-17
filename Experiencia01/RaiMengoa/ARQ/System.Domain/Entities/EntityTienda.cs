using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using SGISystem.Domain.Entities.Keys;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityTienda
    {
        private KeyTienda key;
        private String nombreTienda;
        private String direccion;
        private String idDistrito;
        private String idProvincia;
        private String idRegion;
        private String referencia;
        private Int32 estado;

        public EntityTienda()
        {

        }

        public EntityTienda
         (KeyTienda oKey,
          String oNombreTienda,
          String oDireccion,
          String oIdDistrito,
          String oIdProvincia,
          String oIdRegion,
          String oReferencia,
          Int32 oEstado
          )
        {
         this.key = oKey;
         this.nombreTienda = oNombreTienda;
         this.direccion = oDireccion;
         this.idDistrito = oIdDistrito;
         this.idProvincia = oIdProvincia;
         this.idRegion = oIdRegion;
         this.referencia = oReferencia;
         this.estado = oEstado;
        }

        [DataMember]
        public KeyTienda Key
        {
            get { return key; }
            set { key = value; }
        }

        [DataMember]
        public String NombreTienda
        {
            get { return nombreTienda; }
            set { nombreTienda = value; }
        }

        [DataMember]
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        [DataMember]
        public String IdDistrito
        {
            get { return idDistrito; }
            set { idDistrito = value; }
        }

        [DataMember]
        public String IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }

        [DataMember]
        public String IdRegion
        {
            get { return idRegion; }
            set { idRegion = value; }
        }

        [DataMember]
        public String Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        [DataMember]
        public Int32 Estado
        {
            get { return estado; }
            set { estado = value; }
        } 


        public static EntityTienda Create(IDataReader fila)
        {
            return new EntityTienda(
                Keys.KeyTienda.Create(fila),
                DataCreator.CreateString(fila, "NombreTienda"),
                DataCreator.CreateString(fila, "Direccion"),
                DataCreator.CreateString(fila, "IdDistrito"),
                DataCreator.CreateString(fila, "IdProvincia"),
                DataCreator.CreateString(fila, "IdRegion"),
                DataCreator.CreateString(fila, "Referencia"),
                DataCreator.CreateInt32(fila, "Estado"));
        }


        public static EntityTienda Empty
        {
            get
            {
                return new EntityTienda(
                Keys.KeyTienda.Empty,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.UnoNegativo);
            }
        }
    }
}
