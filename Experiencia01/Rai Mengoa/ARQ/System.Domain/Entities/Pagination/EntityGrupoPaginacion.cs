using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Pagination
{
    [DataContract]
    public class EntityGrupoPaginacion : EntityGrupo
    {
        public EntityGrupoPaginacion()
        {

        }

        public EntityGrupoPaginacion(
           Keys.KeyGrupo okey,
           Int32 okeyPadre,
           String oDescripcionCorta,
           String oDescripcionLarga,
           Int32 oEstado,
           String oGrupoPadreNombre,
           String oEstadoNombre,
           EntityPaginacion oEntityPaginacion)
        : base (okey, okeyPadre, oDescripcionCorta, oDescripcionLarga, oEstado)
        {
            this.entityPaginacion = oEntityPaginacion;
            this.grupoPadreNombre = oGrupoPadreNombre;
            this.estadonombre = oEstadoNombre;
        }
        
        private EntityPaginacion entityPaginacion;

        [DataMember]
        public EntityPaginacion EntityPaginacion
        {
            get { return entityPaginacion; }
            set { entityPaginacion = value; }
        }

        private String grupoPadreNombre;

        [DataMember]
        public String GrupoPadreNombre
        {
            get { return grupoPadreNombre; }
            set { grupoPadreNombre = value; }
        }

        private String estadonombre;

        [DataMember]
        public String EstadoNombre
        {
            get { return estadonombre; }
            set { estadonombre = value; }
        }
    
        public static EntityGrupoPaginacion CreatePag(IDataReader row)
        {
            return new EntityGrupoPaginacion(
               Keys.KeyGrupo.Create(row),
               DataCreator.CreateInt32(row, "IDGrupoPadre"),
               DataCreator.CreateString(row, "DescripcionCorta"),
               DataCreator.CreateString(row, "DescripcionLarga"),
               DataCreator.CreateInt32(row, "Estado"),
               DataCreator.CreateString(row, "GrupoPadreNombre"),
               DataCreator.CreateString(row, "EstadoNombre"),
               null);
        }

        public static EntityGrupoPaginacion EmptyPag
        {
            get
            {
                return new EntityGrupoPaginacion(
                    Keys.KeyGrupo.Empty,
                    Parameters.Cero,
                    Parameters.Vacio,
                    Parameters.Vacio,
                    Parameters.UnoNegativo,
                    Parameters.Vacio,
                    Parameters.Vacio,
                    null);
            }
        }

    }
}
