using SGI.MVCCliente.Helpers;
using SGI.Proxy.Services.CargoServices;
using SGI.Proxy.Services.EmpleadoServices;
using SGI.Proxy.Services.TiendaServices;
using SGI.Proxy.Services.UsuarioServices;
using System;
using System.Collections.Generic;

namespace SGI.MVCCliente.ViewModel
{
    public class EmpleadoViewModel
    {
        private EntityEmpleado entityEmpleado;

        public EntityEmpleado EntityEmpleado
        {
            get { return entityEmpleado; }
            set { entityEmpleado = value; }
        }

        private EntityEmpleadoPaginacion entityEmpleadoPaginacion;

        public EntityEmpleadoPaginacion EntityEmpleadoPaginacion
        {
            get { return entityEmpleadoPaginacion; }
            set { entityEmpleadoPaginacion = value; }
        }

        private IList<EntityEmpleado> listEmpleado;

        public IList<EntityEmpleado> ListEmpleado
        {
            get { return listEmpleado; }
            set { listEmpleado = value; }
        }

        private IList<EntityEmpleadoPaginacion> listEmpleadoPaginado;

        public IList<EntityEmpleadoPaginacion> ListEmpleadoPaginado
        {
            get { return listEmpleadoPaginado; }
            set { listEmpleadoPaginado = value; }
        }

        private EntityUsuario entityUsuarioEmpleado;

        public EntityUsuario EntityUsuarioEmpleado
        {
            get { return entityUsuarioEmpleado; }
            set { entityUsuarioEmpleado = value; }
        }

        private IList<EntityTienda> listTienda;

        public IList<EntityTienda> ListTienda
        {
            get { return listTienda; }
            set { listTienda = value; }
        }

        private IList<EntityCargo> listCargo;

        public IList<EntityCargo> ListCargo
        {
            get { return listCargo; }
            set { listCargo = value; }
        }

        private IList<EntityEstadoCivil> listEstadoCivil;

        public IList<EntityEstadoCivil> ListEstadoCivil
        {
            get 
            {
                if (null == listEstadoCivil)
                {
                    listEstadoCivil = new List<EntityEstadoCivil>();
                    listEstadoCivil.Add(
                        new EntityEstadoCivil
                        {
                            IdEstadoCivil = Constantes.CaracterSoltero,
                            EstadoCivil = Constantes.CadenaSoltero
                        });
                    listEstadoCivil.Add(
                        new EntityEstadoCivil
                        {
                            IdEstadoCivil = Constantes.CaracterCasado,
                            EstadoCivil = Constantes.CadenaCasado
                        });
                    listEstadoCivil.Add(
                        new EntityEstadoCivil
                        {
                            IdEstadoCivil = Constantes.CaracterViudo,
                            EstadoCivil = Constantes.CadenaViudo
                        });
                    listEstadoCivil.Add(
                        new EntityEstadoCivil
                        {
                            IdEstadoCivil = Constantes.CaracterDivorciado,
                            EstadoCivil = Constantes.CadenaDivorciado
                        });
                }

                return listEstadoCivil; 
            }
        }
    }

    public class EntityEstadoCivil
    {
        public Char IdEstadoCivil { get; set; }
        public String EstadoCivil { get; set; }
    }
}