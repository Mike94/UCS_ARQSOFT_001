using SGISystem.Application.Application;
using SGISystem.Application.Application.Interfaces;
using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Web.Script.Serialization;

namespace SGISystem.Services.Implementation
{
    public class UsuarioServices : IUsuarioServices
    {
        public UsuarioServices()
        {
            _app = new UsuarioApplication();
        }

        private IUsuarioApplication _app;

        public IUsuarioApplication UsuarioApp
        {
            get { return _app; }
            set { _app = value; }
        }
        public Boolean Autenticar(EntityUsuario oEntityUsuario)
        {
            try
            {
                return UsuarioApp.Autenticar(oEntityUsuario);
            }
            catch (Exception)
            {
                throw new FaultException("Error al autenticar usuarios");
            }
        }

        public EntityUsuario Insert(EntityUsuario oEntityUsuario)
        {
            try
            {
                return UsuarioApp.Insert(oEntityUsuario);
            }
            catch (Exception)
            {
                throw new FaultException("Error al insertar usuarios");
            }
        }

        public EntityUsuario Update(EntityUsuario oEntityUsuario)
        {
            try
            {
                return UsuarioApp.Update(oEntityUsuario);
            }
            catch (Exception)
            {
                throw new FaultException("Error al actualizar usuarios");
            }
        }

        public EntityUsuario Delete(EntityUsuario oEntityUsuario)
        {
            try
            {
                return UsuarioApp.Delete(oEntityUsuario);
            }
            catch (Exception)
            {
                throw new FaultException("Error al eliminar usuarios");
            }
        }

        public EntityUsuario SelectByKey(KeyUsuario oKeyUsuario)
        {
            try
            {
                return UsuarioApp.SelectByKey(oKeyUsuario);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar usuarios");
            }
        }

        public IList<EntityUsuario> Select(EntityUsuario oEntityUsuario)
        {
            try
            {
                return UsuarioApp.Select(oEntityUsuario);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar usuarios");
            }
        }

        public IList<EntityUsuarioPaginacion> SelectPagging(ref EntityUsuarioPaginacion oEntityUsuarioPaginacion)
        {
            try
            {
                return UsuarioApp.SelectPagging(ref oEntityUsuarioPaginacion);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar usuarios");
            }
        }
    }
}
