using SGI.Proxy.Services.GrupoServices;
using SGI.Proxy.Services.ProductoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ViewModel
{
    public class ProductoViewModel
    {
        private EntityProducto entityProducto;
        public EntityProducto EntityProducto
        {
            get { return entityProducto; }
            set { entityProducto = value; }
        }

        private EntityGrupo grupo;
        public EntityGrupo Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        private EntityProductoPaginacion entityProductoPaginacion;
        public EntityProductoPaginacion EntityProductoPaginacion
        {
            get { return entityProductoPaginacion; }
            set { entityProductoPaginacion = value; }
        }

        private IList<EntityProducto> listProducto;
        public IList<EntityProducto> ListProducto
        {
            get { return listProducto; }
            set { listProducto = value; }
        }
       
        private IList<EntityProductoPaginacion> listProductoPaginado;
        public IList<EntityProductoPaginacion> ListProductoPaginado
        {
            get { return listProductoPaginado; }
            set { listProductoPaginado = value; }
        }

        private IList<EntityGrupo> listaGrupo;

        public IList<EntityGrupo> ListGrupo
        {
            get { return listaGrupo; }
            set { listaGrupo = value; }
        }

        private Boolean editableCantidadinventario;

        public Boolean EditableCantidadinventario
        {
            get { return editableCantidadinventario; }
            set { editableCantidadinventario = value; }
        }
        
        
    }
}