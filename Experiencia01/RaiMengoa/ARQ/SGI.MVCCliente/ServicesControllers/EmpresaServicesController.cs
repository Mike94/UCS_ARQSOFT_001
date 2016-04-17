using SGI.Proxy.Services.EmpresaServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ServicesControllers
{
    public class EmpresaServicesController
    {
        private IEmpresaServices empresaService;

        public IEmpresaServices EmpresaService
        {
            get
            {
                return (null == empresaService) ?
                    new EmpresaServicesClient() : EmpresaService;
            }
            set { empresaService = value; }
        }

        public IList<EntityEmpresaPaginacion> SelectPagging(ref EntityEmpresaPaginacion oEntityEmpresaPaginacion)
        {
            try
            {
                using (EmpresaServicesClient oEmpresaServices = new EmpresaServicesClient())
                {
                    return oEmpresaServices.SelectPagging(ref oEntityEmpresaPaginacion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityEmpresa> Select(EntityEmpresa oEntityEmpresa)
        {
            try
            {
                return EmpresaService.Select(oEntityEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityTipoEmpresa> SelectTipoEmpresa(EntityTipoEmpresa oEntityTipoEmpresa)
        {
            try
            {
                return EmpresaService.SelectTipoEmpresa(oEntityTipoEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpresa SelectByKey(KeyEmpresa oKeyEmpresa)
        {
            try
            {
                return EmpresaService.SelectByKey(oKeyEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpresa Insert(EntityEmpresa oEntityEmpresa)
        {
            try
            {
                return EmpresaService.Insert(oEntityEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpresa Update(EntityEmpresa oEntityEmpresa)
        {
            try
            {
                return EmpresaService.Update(oEntityEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}