using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityEmpresaPaginacion : EntityEmpresa
    {
        public EntityEmpresaPaginacion()
        {
        }

        public EntityEmpresaPaginacion(
            Keys.KeyEmpresa okey,
           String oCodigoEmpresa,
           String oRazonComercial,
           String oRazonSocial,
           String oRuc,
           String oTelefono,
           String oContacto,
           String oDireccion,
           Int32 oIdTipoEmpresa,
           Int32 oEstado,
           String oEstadoNombre,
           String oTipoEmpresaNombre,
           EntityPaginacion oEntityPaginacion)
            : base(okey, 
            oCodigoEmpresa, 
            oRazonComercial, 
            oRazonSocial, 
            oRuc, 
            oTelefono,
            oContacto, 
            oDireccion, 
            oIdTipoEmpresa,
            oEstado)
        {
            this.entityPaginacion = oEntityPaginacion;
            this.estadoNombre = oEstadoNombre;
            this.tipoEmpresaNombre = oTipoEmpresaNombre;
        }

        private EntityPaginacion entityPaginacion;

        [DataMember]
        public EntityPaginacion EntityPaginacion
        {
            get { return entityPaginacion; }
            set { entityPaginacion = value; }
        }

        private String estadoNombre;

        [DataMember]
        public String EstadoNombre
        {
            get { return estadoNombre; }
            set { estadoNombre = value; }
        }

        private String tipoEmpresaNombre;

        [DataMember]
        public String TipoEmpresaNombre
        {
            get { return tipoEmpresaNombre; }
            set { tipoEmpresaNombre = value; }
        }

        public static EntityEmpresaPaginacion CreatePag(IDataReader row)
        {
            return new EntityEmpresaPaginacion(
               Keys.KeyEmpresa.Create(row),
               DataCreator.CreateString(row, "CodigoEmpresa"),
               DataCreator.CreateString(row, "RazonComercial"),
               DataCreator.CreateString(row, "RazonSocial"),
               DataCreator.CreateString(row, "RUC"),
               DataCreator.CreateString(row, "Telefono"),
               DataCreator.CreateString(row, "Contacto"),
               DataCreator.CreateString(row, "Direccion"),
               DataCreator.CreateInt32(row, "IdTipoEmpresa"),
               DataCreator.CreateInt32(row, "Estado"),
               DataCreator.CreateString(row, "EstadoNombre"),
               DataCreator.CreateString(row, "TipoEmpresaNombre"),
               null);
        }

        public static EntityEmpresaPaginacion EmptyPag
        {
            get
            {
                return new EntityEmpresaPaginacion(
                    Keys.KeyEmpresa.Empty,
                    Parameters.Vacio,
                    Parameters.Vacio,
                    Parameters.Vacio,
                    Parameters.Vacio,
                    Parameters.Vacio, 
                    Parameters.Vacio,
                    Parameters.Vacio,
                    Parameters.Cero,
                    Parameters.UnoNegativo,
                    Parameters.Vacio,
                    Parameters.Vacio,
                    null);
            }
        }
        
    }
}
