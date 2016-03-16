using SGI.Proxy.Services.UsuarioServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace SGI.MVCCliente.ServicesControllers
{
    public class UsuarioServicesController
    {
        private IUsuarioServices usuarioService;

        public IUsuarioServices UsuarioService
        {
            get { return (null == usuarioService) ? 
                 new UsuarioServicesClient() : usuarioService; }
            set { usuarioService = value; }
        }

        public Boolean AutenticarUsuario(EntityUsuario oEntityUsuario)
        {
            try
            {
                return UsuarioService.Autenticar(oEntityUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityUsuario Insertar(EntityUsuario oEntityUsuario)
        {
            try
            {
                return UsuarioService.Insert(oEntityUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityUsuario Update(EntityUsuario oEntityUsuario)
        {
            try
            {
                return UsuarioService.Update(oEntityUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityUsuario> Select(EntityUsuario oEntityUsuario)
        {
            try
            {
                return UsuarioService.Select(oEntityUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityUsuario SelectByKey(KeyUsuario oKeyUsuario)
        {
            try
            {
                return UsuarioService.SelectByKey(oKeyUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}