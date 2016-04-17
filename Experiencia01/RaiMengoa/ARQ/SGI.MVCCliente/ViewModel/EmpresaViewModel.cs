using SGI.Proxy.Services.EmpresaServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ViewModel
{
    public class EmpresaViewModel
    {
        private EntityEmpresa entityEmpresa;

        public EntityEmpresa EntityEmpresa
        {
            get { return entityEmpresa; }
            set { entityEmpresa = value; }
        }

        private EntityEmpresaPaginacion entityEmpresaPaginacion;

        public EntityEmpresaPaginacion EntityEmpresaPaginacion
        {
            get { return entityEmpresaPaginacion; }
            set { entityEmpresaPaginacion = value; }
        }

        private IList<EntityEmpresa> listEmpresa;

        public IList<EntityEmpresa> ListEmpresa
        {
            get { return listEmpresa; }
            set { listEmpresa = value; }
        }

        private IList<EntityEmpresaPaginacion> listEmpresaPaginado;

        public IList<EntityEmpresaPaginacion> ListEmpresaPaginado
        {
            get { return listEmpresaPaginado; }
            set { listEmpresaPaginado = value; }
        }

        private IList<EntityTipoEmpresa> listTipoEmpresa;

        public IList<EntityTipoEmpresa> ListTipoEmpresa
        {
            get { return listTipoEmpresa; }
            set { listTipoEmpresa = value; }
        }
    }
}