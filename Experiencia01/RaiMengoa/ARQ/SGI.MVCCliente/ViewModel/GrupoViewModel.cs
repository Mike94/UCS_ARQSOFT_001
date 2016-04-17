using SGI.Proxy.Services.GrupoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ViewModel
{
    public class GrupoViewModel
    {
        private EntityGrupo entityGrupo;

        public EntityGrupo EntityGrupo
        {
            get { return entityGrupo; }
            set { entityGrupo = value; }
        }

        private EntityGrupoPaginacion entityGrupoPaginacion;

        public EntityGrupoPaginacion EntityGrupoPaginacion
        {
            get { return entityGrupoPaginacion; }
            set { entityGrupoPaginacion = value; }
        }

        private IList<EntityGrupo> listGrupo;

        public IList<EntityGrupo> ListGrupo
        {
            get { return listGrupo; }
            set { listGrupo = value; }
        }

        private IList<EntityGrupoPaginacion> listGrupoPaginado;

        public IList<EntityGrupoPaginacion> ListGrupoPaginado
        {
            get { return listGrupoPaginado; }
            set { listGrupoPaginado = value; }
        }
    }
}