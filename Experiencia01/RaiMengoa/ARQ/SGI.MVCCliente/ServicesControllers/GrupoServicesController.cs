using SGI.Proxy.Services.GrupoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ServicesControllers
{
    public class GrupoServicesController
    {
        private IGrupoServices grupoService;

        public IGrupoServices GrupoService
        {
            get
            {
                return (null == grupoService) ?
                    new GrupoServicesClient() : grupoService;
            }
            set { grupoService = value; }
        }

        public IList<EntityGrupoPaginacion> SelectPagging(ref EntityGrupoPaginacion oEntityGrupoPaginacion)
        {
            try
            {
                using (GrupoServicesClient oGrupoServices = new GrupoServicesClient())
                {
                    return oGrupoServices.SelectPagging(ref oEntityGrupoPaginacion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityGrupo> Select(EntityGrupo oEntityGrupo)
        {
            try
            {
                return GrupoService.Select(oEntityGrupo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityGrupo SelectByKey(KeyGrupo oKeyGrupo)
        {
            try
            {
                return GrupoService.SelectByKey(oKeyGrupo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityGrupo Insert(EntityGrupo oEntityGrupo)
        {
            try
            {
                return GrupoService.Insert(oEntityGrupo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityGrupo Update(EntityGrupo oEntityGrupo)
        {
            try
            {
                return GrupoService.Update(oEntityGrupo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}