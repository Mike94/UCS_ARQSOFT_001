using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Pagination
{
    [DataContract]
    public class EntityTiendaPaginacion : EntityTienda
    {
        public EntityTiendaPaginacion()
        {
        }

        public EntityTiendaPaginacion
           (KeyTienda oKey,
            String oNombreTienda,
            String oDireccion,
            String oIdDistrito,
            String oIdProvincia,
            String oIdRegion,
            String oNombreDistrito,
		    String oNombreProvincia,
		    String oNombreDepartamento,
            String oReferencia,
            Int32 oEstado,
            String oEstadoNombre,
            EntityPaginacion oEntityPaginacion)
            : base(oKey, 
            oNombreTienda, 
            oDireccion, 
            oIdDistrito, 
            oIdProvincia, 
            oIdRegion, 
            oReferencia, 
            oEstado)
        {
            this.entityPaginacion = oEntityPaginacion;
            this.nombreDistrito = oNombreDistrito;
            this.nombreProvincia = oNombreProvincia;
            this.nombreDepartamento = oNombreDepartamento;
        }

        private EntityPaginacion entityPaginacion;

        [DataMember]
        public EntityPaginacion EntityPaginacion
        {
            get { return entityPaginacion; }
            set { entityPaginacion = value; }
        }

        private String nombreDistrito;

        [DataMember]
        public String NombreDistrito
        {
            get { return nombreDistrito; }
            set { nombreDistrito = value; }
        }

        private String nombreProvincia;

        [DataMember]
        public String NombreProvincia
        {
            get { return nombreProvincia; }
            set { nombreProvincia = value; }
        }

        private String nombreDepartamento;

        [DataMember]
        public String NombreDepartamento
        {
            get { return nombreDepartamento; }
            set { nombreDepartamento = value; }
        }

        private String estadonombre;

        [DataMember]
        public String EstadoNombre
        {
            get { return estadonombre; }
            set { estadonombre = value; }
        }

        public static EntityTiendaPaginacion CreatePag(IDataReader fila)
        {
            return new EntityTiendaPaginacion(
                Keys.KeyTienda.Create(fila),
                DataCreator.CreateString(fila, "NombreTienda"),
                DataCreator.CreateString(fila, "Direccion"),
                DataCreator.CreateString(fila, "IdDistrito"),
                DataCreator.CreateString(fila, "IdProvincia"),
                DataCreator.CreateString(fila, "IdRegion"),
                DataCreator.CreateString(fila, "NombreDistrito"),
                DataCreator.CreateString(fila, "NombreProvincia"),
                DataCreator.CreateString(fila, "NombreDepartamento"),
                DataCreator.CreateString(fila, "Referencia"),
                DataCreator.CreateInt32(fila, "Estado"),
                DataCreator.CreateString(fila, "EstadoNombre"),
                null);
        }


        public static EntityTiendaPaginacion EmptyPag
        {
            get
            {
                return new EntityTiendaPaginacion(
                Keys.KeyTienda.Empty,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.UnoNegativo,
                Parameters.Vacio,
                null);
            }
        }

    }
}
