using SGISystem.Application.Application;
using SGISystem.Application.Application.Interfaces;
using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.Services.Implementation
{
    public class EmpresaServices : IEmpresaServices
    {
        public EmpresaServices()
        {
            _app = new EmpresaApplication();
            _appTipo = new TipoEmpresaApplication();
        }

        private IEmpresaApplication _app;
        private ITipoEmpresaApplication _appTipo;

        public IEmpresaApplication EmpresaApp
        {
            get { return _app; }
            set { _app = value; }
        }

        public ITipoEmpresaApplication TipoEmpresaApp
        {
            get { return _appTipo; }
            set { _appTipo = value; }
        }

        public IList<EntityEmpresa> Select(EntityEmpresa oEntityEmpresa)
        {
            try 
	        {	        
		        return EmpresaApp.Select(oEntityEmpresa);
	        }
	        catch (Exception)
	        {
		        throw new FaultException("Error al seleccionar Empresas");
	        }
        }

        public IList<EntityEmpresaPaginacion> SelectPagging(ref EntityEmpresaPaginacion oEntityEmpresaPaginacion)
        {
            try 
	        {	        
		        return EmpresaApp.SelectPagging(ref oEntityEmpresaPaginacion);
	        }
	        catch (Exception)
	        {
		        throw new FaultException("Error al seleccionar Empresas");
	        }
        }

        public EntityEmpresa Insert(EntityEmpresa oEntityEmpresa)
        {
            try
            {
                return EmpresaApp.Insert(oEntityEmpresa);
            }
            catch (Exception)
            {
                throw new FaultException("Error al insertar Empresas");
            }
        }

        public EntityEmpresa Update(EntityEmpresa oEntityEmpresa)
        {
            try
            {
                return EmpresaApp.Update(oEntityEmpresa);
            }
            catch (Exception)
            {
                throw new FaultException("Error al actualizar Empresas");
            }
        }

        public EntityEmpresa Delete(EntityEmpresa oEntityEmpresa)
        {
            try
            {
                return EmpresaApp.Update(oEntityEmpresa);
            }
            catch (Exception)
            {
                throw new FaultException("Error al eliminar Empresas");
            }
        }

        public EntityEmpresa SelectByKey(KeyEmpresa oKeyEmpresa)
        {
            try
            {
                return EmpresaApp.SelectByKey(oKeyEmpresa);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Empresas");
            }
        }


        public IList<EntityTipoEmpresa> SelectTipoEmpresa(EntityTipoEmpresa oEntityTipoEmpresa)
        {
            try
            {
                return TipoEmpresaApp.Select(oEntityTipoEmpresa);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Tipos de Empresas");
            }
        }
    }
}
