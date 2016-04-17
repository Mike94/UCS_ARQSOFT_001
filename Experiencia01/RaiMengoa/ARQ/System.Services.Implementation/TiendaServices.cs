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
    public class TiendaServices : ITiendaServices
    {
        public TiendaServices()
        {
            _app = new TiendaApplication();
        }

        private ITiendaApplication _app;

        public ITiendaApplication TiendaApp
        {
            get { return _app; }
            set { _app = value; }
        }


        public IList<EntityTienda> SelectTest()
        {
            try
            {
                return TiendaApp.Select(EntityTienda.Empty);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Tiendas");
            }
        }

        public EntityTienda SelectByKey(KeyTienda oKeyTienda)
        {
            try
            {
                return TiendaApp.SelectByKey(oKeyTienda);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Tiendas");
            }
        }

        public IList<EntityTienda> Select(EntityTienda oEntityTienda)
        {
            try
            {
                return TiendaApp.Select(oEntityTienda);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Tiendas");
            }
        }

        public IList<EntityTiendaPaginacion> SelectPagging(ref EntityTiendaPaginacion oEntityTiendaPaginacion)
        {
            try
            {
                return TiendaApp.SelectPagging(ref oEntityTiendaPaginacion);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Tiendas");
            }
        }

        public EntityTienda Insert(EntityTienda oEntityTienda)
        {
            try
            {
                return TiendaApp.Insert(oEntityTienda);
            }
            catch (Exception)
            {
                throw new FaultException("Error al insertar Tiendas");
            }
        }

        public EntityTienda Update(EntityTienda oEntityTienda)
        {
            try
            {
                return TiendaApp.Update(oEntityTienda);
            }
            catch (Exception)
            {
                throw new FaultException("Error al actualizar Tiendas");
            }
        }

        public EntityTienda Delete(EntityTienda oEntityTienda)
        {
            try
            {
                return TiendaApp.Delete(oEntityTienda);
            }
            catch (Exception)
            {
                throw new FaultException("Error al eliminar Tiendas");
            }
        }
    }
}
