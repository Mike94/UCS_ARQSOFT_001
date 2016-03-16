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
    public class CargoServices : ICargoServices
    {
        public CargoServices()
        {
            _app = new CargoApplication();
        }

        private ICargoApplication _app;

        public ICargoApplication CargoApp
        {
            get { return _app; }
            set { _app = value; }
        }


        public IList<EntityCargo> SelectTest()
        {
            try
            {
                return CargoApp.Select(EntityCargo.Empty);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Cargos");
            }
        }

        public EntityCargo SelectByKey(KeyCargo oKeyCargo)
        {
            try
            {
                return CargoApp.SelectByKey(oKeyCargo);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Cargos");
            }
        }

        public IList<EntityCargo> Select(EntityCargo oEntityCargo)
        {
            try
            {
                return CargoApp.Select(oEntityCargo);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Cargos");
            }
        }

        public IList<EntityCargoPaginacion> SelectPagging(ref EntityCargoPaginacion oEntityCargoPaginacion)
        {
            try
            {
                return CargoApp.SelectPagging(ref oEntityCargoPaginacion);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Cargos");
            }
        }

        public EntityCargo Insert(EntityCargo oEntityCargo)
        {
            try
            {
                return CargoApp.Insert(oEntityCargo);
            }
            catch (Exception)
            {
                throw new FaultException("Error al insertar Cargos");
            }
        }

        public EntityCargo Update(EntityCargo oEntityCargo)
        {
            try
            {
                return CargoApp.Update(oEntityCargo);
            }
            catch (Exception)
            {
                throw new FaultException("Error al actualizar Cargos");
            }
        }

        public EntityCargo Delete(EntityCargo oEntityCargo)
        {
            try
            {
                return CargoApp.Delete(oEntityCargo);
            }
            catch (Exception)
            {
                throw new FaultException("Error al eliminar Cargos");
            }
        }
    }
}
