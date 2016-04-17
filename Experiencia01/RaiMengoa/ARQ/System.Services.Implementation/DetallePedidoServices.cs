using SGISystem.Domain.Entities;
using System;
using System.Collections.Generic;
using SGISystem.Application.Application;
using SGISystem.Application.Application.Interfaces;
using SGISystem.Services.Contracts;
using System.ServiceModel;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;

namespace SGISystem.Services.Implementation
{
    public class DetallePedidoServices : IDetallePedidoServices
    {
        public DetallePedidoServices()
        {
            _app = new DetallePedidoApplication();
        }

        private IDetallePedidoApplication _app;

        public IDetallePedidoApplication DetallePedidoApp
        {
            get { return _app; }
            set { _app = value; }
        }

        public EntityDetallePedido SelectByKey(KeyDetallePedido oKeyDetallePedido)
        {
            try
            {
                return DetallePedidoApp.SelectByKey(oKeyDetallePedido);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar DetallePedidos");
            }
        }

        public IList<EntityDetallePedido> Select(EntityDetallePedido oEntityDetallePedido)
        {
            try
            {
                return DetallePedidoApp.Select(oEntityDetallePedido);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar DetallePedidos");
            }
        }

        public IList<EntityDetallePedidoPaginacion> SelectPagging(ref EntityDetallePedidoPaginacion oEntityDetallePedidoPaginacion)
        {
            try
            {
                return DetallePedidoApp.SelectPagging(ref oEntityDetallePedidoPaginacion);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar DetallePedidos");
            }
        }

        public EntityDetallePedido Insert(EntityDetallePedido oEntityDetallePedido)
        {
            try
            {
                return DetallePedidoApp.Insert(oEntityDetallePedido);
            }
            catch (Exception)
            {
                throw new FaultException("Error al insertar DetallePedidos");
            }
        }

        public EntityDetallePedido Update(EntityDetallePedido oEntityDetallePedido)
        {
            try
            {
                return DetallePedidoApp.Update(oEntityDetallePedido);
            }
            catch (Exception)
            {
                throw new FaultException("Error al actualizar DetallePedidos");
            }
        }

        public EntityDetallePedido Delete(EntityDetallePedido oEntityDetallePedido)
        {
            try
            {
                return DetallePedidoApp.Delete(oEntityDetallePedido);
            }
            catch (Exception)
            {
                throw new FaultException("Error al eliminar DetallePedidos");
            }
        }

    }
}
