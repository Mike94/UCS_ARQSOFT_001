using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Pagination
{
    public class EntityCargoPaginacion : EntityCargo
    {
        public EntityCargoPaginacion()
        {

        }

        public EntityCargoPaginacion(
           Keys.KeyCargo okey,
           String oNombreCargo,
           String oDescripcion,
           Int32 oEstado,
           String oEstadoNombre,
           EntityPaginacion oEntityPaginacion)
            :base(
            okey,
            oNombreCargo,
            oDescripcion,
            oEstado
        )
        {
            this.estadoNombre = oEstadoNombre;
            this.entityPaginacion = oEntityPaginacion;
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

        public static EntityCargoPaginacion CreatePag(IDataReader fila)
        {
            return new EntityCargoPaginacion(
                Keys.KeyCargo.Create(fila),
                DataCreator.CreateString(fila, "NombreCargo"),
                DataCreator.CreateString(fila, "Descripcion"),
                DataCreator.CreateInt32(fila, "Estado"),
                DataCreator.CreateString(fila, "EstadoNombre"),
                null);
        }


        public static EntityCargoPaginacion EmptyPag
        {
            get
            {
                return new EntityCargoPaginacion(
                Keys.KeyCargo.Empty,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.UnoNegativo,
                Parameters.Vacio,
                null);
            }
        }
    }
}
