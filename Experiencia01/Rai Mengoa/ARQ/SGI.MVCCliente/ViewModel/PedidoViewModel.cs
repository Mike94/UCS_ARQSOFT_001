using SGI.MVCCliente.Helpers;
using SGI.Proxy.Services.CargoServices;
using SGI.Proxy.Services.EmpleadoServices;
using SGI.Proxy.Services.EmpresaServices;
using SGI.Proxy.Services.GrupoServices;
using SGI.Proxy.Services.PedidoServices;
using SGI.Proxy.Services.ProductoServices;
using SGI.Proxy.Services.UsuarioServices;
using System;
using System.Collections.Generic;

namespace SGI.MVCCliente.ViewModel
{
    public class PedidoViewModel
    {
        private EntityPedido entityPedido;
        public EntityPedido EntityPedido
        {
            get { return entityPedido; }
            set { entityPedido = value; }
        }

        private EntityDetallePedido entityDetallePedido;
        public EntityDetallePedido EntityDetallePedido
        {
            get { return entityDetallePedido; }
            set { entityDetallePedido = value; }
        }

        private EntityPedidoPaginacion entityPedidoPaginacion;
        public EntityPedidoPaginacion EntityPedidoPaginacion
        {
            get { return entityPedidoPaginacion; }
            set { entityPedidoPaginacion = value; }
        }

        private IList<EntityPedido> listPedido;
        public IList<EntityPedido> ListPedido
        {
            get { return listPedido; }
            set { listPedido = value; }
        }

        private IList<EntityPedidoPaginacion> listPedidoPaginado;
        public IList<EntityPedidoPaginacion> ListPedidoPaginado
        {
            get { return listPedidoPaginado; }
            set { listPedidoPaginado = value; }
        }

        private IList<EntityEmpresa> listEmpresa;
        public IList<EntityEmpresa> ListEmpresa
        {
            get { return listEmpresa; }
            set { listEmpresa = value; }
        }

        private ProductoViewModel productoViewModel;
        public ProductoViewModel ProductoViewModel
        {
            get { return productoViewModel; }
            set { productoViewModel = value; }
        }

        private GrupoViewModel grupoViewModel;
        public GrupoViewModel GrupoViewModel
        {
            get { return grupoViewModel; }
            set { grupoViewModel = value; }
        }
        
    }
}