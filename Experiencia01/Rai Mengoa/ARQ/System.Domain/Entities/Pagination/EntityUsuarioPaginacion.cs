using System;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{

    [DataContract]
    public class EntityUsuarioPaginacion : EntityUsuario
    {
        private EntityPaginacion entityPaginacion;

        public EntityUsuarioPaginacion()
        {
        }

        public EntityUsuarioPaginacion(
           Keys.KeyUsuario okey,
           String oUsuario,
           String oClave,
           Int32 oEstado,
           EntityPaginacion oEntityPaginacion)
          :base(okey, oUsuario, oClave, oEstado)
        {
            this.entityPaginacion = oEntityPaginacion;
        }

        [DataMember]
        public EntityPaginacion EntityPaginacion
        {
            get { return entityPaginacion; }
            set { entityPaginacion = value; }
        }


        public static EntityUsuarioPaginacion CreatePag(System.Data.IDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
