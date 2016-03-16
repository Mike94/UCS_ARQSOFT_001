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
    public class UbigeoServices : IUbigeoServices
    {
        public UbigeoServices()
        {
            _appDepa = new DepartamentoApplication();
            _appPro = new ProvinciaApplication();
            _appDis = new DistritoApplication();
        }

        private IDepartamentoApplication _appDepa;
        private IProvinciaApplication _appPro;
        private IDistritoApplication _appDis;
        
        public IDepartamentoApplication DepartamentoApp
        {
            get { return _appDepa; }
            set { _appDepa = value; }
        }

        public IProvinciaApplication ProvinciaApp
        {
            get { return _appPro; }
            set { _appPro = value; }
        }

        public IDistritoApplication DistritoApp
        {
            get { return _appDis; }
            set { _appDis = value; }
        }

        public IList<EntityDistrito> SelectDistrito(EntityDistrito oEntityDistrito)
        {
            try
            {
                return DistritoApp.Select(oEntityDistrito);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Distritos");
            }
        }

        public IList<EntityProvincia> SelectProvincia(EntityProvincia oEntityProvincia)
        {
            try
            {
                return ProvinciaApp.Select(oEntityProvincia);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Provincias");
            }
        }

        public IList<EntityDepartamento> SelectDepartamento(EntityDepartamento oEntityDepartamento)
        {
            try
            {
                return DepartamentoApp.Select(oEntityDepartamento);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Departamentos");
            }
        }
    }
}
