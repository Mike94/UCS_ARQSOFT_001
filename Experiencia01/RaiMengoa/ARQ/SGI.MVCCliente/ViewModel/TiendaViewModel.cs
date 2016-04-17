using SGI.Proxy.Services.TiendaServices;
using SGI.Proxy.Services.UbigeoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ViewModel
{
    public class TiendaViewModel
    {
        private EntityTienda entityTienda;

        public EntityTienda EntityTienda
        {
            get { return entityTienda; }
            set { entityTienda = value; }
        }

        private EntityTiendaPaginacion entityTiendaPaginacion;

        public EntityTiendaPaginacion EntityTiendaPaginacion
        {
            get { return entityTiendaPaginacion; }
            set { entityTiendaPaginacion = value; }
        }

        private IList<EntityTienda> listTienda;

        public IList<EntityTienda> ListTienda
        {
            get { return listTienda; }
            set { listTienda = value; }
        }

        private IList<EntityTiendaPaginacion> listTiendaPaginado;

        public IList<EntityTiendaPaginacion> ListTiendaPaginado
        {
            get { return listTiendaPaginado; }
            set { listTiendaPaginado = value; }
        }

        private IList<EntityDepartamento> listDepartamento;

        public IList<EntityDepartamento> ListDepartamento
        {
            get { return listDepartamento; }
            set { listDepartamento = value; }
        }

        private IList<EntityProvincia> listProvincia;

        public IList<EntityProvincia> ListProvincia
        {
            get { return listProvincia; }
            set { listProvincia = value; }
        }

        private IList<EntityDistrito> listDistrito;

        public IList<EntityDistrito> ListDistrito
        {
            get { return listDistrito; }
            set { listDistrito = value; }
        }
    }
}