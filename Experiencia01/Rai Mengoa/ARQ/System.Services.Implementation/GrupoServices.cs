using SGISystem.Application.Application;
using SGISystem.Application.Application.Interfaces;
using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace SGISystem.Services.Implementation
{
    public class GrupoServices : IGrupoServices
    {
        public GrupoServices()
        {
            _app = new GrupoApplication();
        }

        private IGrupoApplication _app;

        public IGrupoApplication GrupoApp
        {
            get { return _app; }
            set { _app = value; }
        }


        public IList<EntityGrupo> SelectTest()
        {
            try
            {
                return GrupoApp.Select(EntityGrupo.Empty);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Grupos");
            }
        }

        public EntityGrupo SelectByKey(KeyGrupo oKeyGrupo)
        {
            try
            {
                return GrupoApp.SelectByKey(oKeyGrupo);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Grupos");
            }
        }

        public IList<EntityGrupo> Select(EntityGrupo oEntityGrupo)
        {
            try
            {
                return GrupoApp.Select(oEntityGrupo);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Grupos");
            }
        }

        public IList<EntityGrupoPaginacion> SelectPagging(ref EntityGrupoPaginacion oEntityGrupoPaginacion)
        {
            try
            {
                return GrupoApp.SelectPagging(ref oEntityGrupoPaginacion);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Grupos");
            }
        }

        public EntityGrupo Insert(EntityGrupo oEntityGrupo)
        {
            try
            {
                return GrupoApp.Insert(oEntityGrupo);
            }
            catch (Exception)
            {
                throw new FaultException("Error al insertar Grupos");
            }
        }

        public EntityGrupo Update(EntityGrupo oEntityGrupo)
        {
            try
            {
                return GrupoApp.Update(oEntityGrupo);
            }
            catch (Exception)
            {
                throw new FaultException("Error al actualizar Grupos");
            }
        }

        public EntityGrupo Delete(EntityGrupo oEntityGrupo)
        {
            try
            {
                return GrupoApp.Delete(oEntityGrupo);
            }
            catch (Exception)
            {
                throw new FaultException("Error al eliminar Grupos");
            }
        }
      
    }
}
