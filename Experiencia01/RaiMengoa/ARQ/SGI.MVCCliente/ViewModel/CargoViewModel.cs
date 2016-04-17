using SGI.Proxy.Services.CargoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ViewModel
{
    public class CargoViewModel
    {
        private EntityCargo entityCargo;

        public EntityCargo EntityCargo
        {
            get { return entityCargo; }
            set { entityCargo = value; }
        }

        private EntityCargoPaginacion entityCargoPaginacion;

        public EntityCargoPaginacion EntityCargoPaginacion
        {
            get { return entityCargoPaginacion; }
            set { entityCargoPaginacion = value; }
        }

        private IList<EntityCargo> listCargo;

        public IList<EntityCargo> ListCargo
        {
            get { return listCargo; }
            set { listCargo = value; }
        }

        private IList<EntityCargoPaginacion> listCargoPaginado;

        public IList<EntityCargoPaginacion> ListCargoPaginado
        {
            get { return listCargoPaginado; }
            set { listCargoPaginado = value; }
        }
    }
}