using SGI.MVCCliente.Controllers.Filters;
using SGI.MVCCliente.Helpers;
using SGI.MVCCliente.ServicesControllers;
using SGI.MVCCliente.ViewModel;
using SGI.Proxy.Services.CargoServices;
using SGI.Proxy.Services.EmpleadoServices;
using SGI.Proxy.Services.TiendaServices;
using SGI.Proxy.Services.UsuarioServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SGI.MVCCliente.Controllers
{
    public class EmpleadoController : Controller
    {
        [RequiresAuthenticationAttribute]
        public ActionResult Index(EmpleadoViewModel oEmpleadoViewModel)
        {
            oEmpleadoViewModel.EntityEmpleadoPaginacion = new EntityEmpleadoPaginacion { Estado = Constantes.UnoNegativo };
            oEmpleadoViewModel.ListEmpleadoPaginado = new List<EntityEmpleadoPaginacion>();
            return View(oEmpleadoViewModel);
        }


        public ActionResult EmpleadoGridPV(EmpleadoViewModel oEmpleadoViewModel, Int32 pageIndex)
        {
            EmpleadoServicesController oServices = new EmpleadoServicesController();

            if (null == oEmpleadoViewModel.EntityEmpleadoPaginacion.EntityPaginacion)
            {
                oEmpleadoViewModel.EntityEmpleadoPaginacion.EntityPaginacion = new SGI.Proxy.Services.EmpleadoServices.EntityPaginacion();
                oEmpleadoViewModel.EntityEmpleadoPaginacion.EntityPaginacion.PageIndex = (pageIndex != Constantes.Cero) ? pageIndex : Constantes.PageIndex;
                oEmpleadoViewModel.EntityEmpleadoPaginacion.EntityPaginacion.RowsPerPage = Constantes.RowsPerPage;
            }

            EntityEmpleadoPaginacion oEntityEmpleadoPaginacion = oEmpleadoViewModel.EntityEmpleadoPaginacion;

            IList<EntityEmpleadoPaginacion> oListEmpleado = oServices.SelectPagging(ref oEntityEmpleadoPaginacion);

            oEmpleadoViewModel.ListEmpleadoPaginado = oListEmpleado;
            oEmpleadoViewModel.EntityEmpleadoPaginacion = oEntityEmpleadoPaginacion;

            return PartialView(Constantes.EmpleadoGridPV, oEmpleadoViewModel);
        }

        public ActionResult InnerEdit(KeyEmpleado key)
        {
            return Edit(key);
        }

        public ActionResult Add()
        {
            return Edit(new KeyEmpleado());
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(KeyEmpleado oKey)
        {
            EmpleadoServicesController oServices = new EmpleadoServicesController();
            UsuarioServicesController oUsuarioServices = new UsuarioServicesController();
            CargoServicesController oCargoServices = new CargoServicesController();
            TiendaServicesController oTiendaServices = new TiendaServicesController();

            EmpleadoViewModel oEmpleadoViewModel = new EmpleadoViewModel();

            EntityEmpleado oEntityEmpleado = oServices.SelectByKey(oKey);

            oEmpleadoViewModel.ListCargo = oCargoServices.Select
                (new EntityCargo 
                { 
                    Key = new KeyCargo { IDCargo = -1 },
                    Estado = Constantes.Activo
                });
            oEmpleadoViewModel.ListTienda = oTiendaServices.Select
                (new EntityTienda
                {
                    Key = new KeyTienda {CodTienda = Constantes.CadenaVacio },
                    Estado = Constantes.Activo
                });

            oEmpleadoViewModel.EntityEmpleado = oEntityEmpleado;

            KeyUsuario oKeyUsuario = new KeyUsuario { IDUsuario = oEntityEmpleado.Key.IDEmpleado };
            oEmpleadoViewModel.EntityUsuarioEmpleado = oUsuarioServices.SelectByKey(oKeyUsuario);
            

            return PartialView(Constantes.EmpleadoUsuarioEditPV, oEmpleadoViewModel);
        }

        public JsonResult Guardar(EmpleadoViewModel oEmpleadoViewModel)
        {
            List<String> resultado = new List<String>();
            resultado.Add("true");
            resultado.Add(Constantes.GuardadoExitoso);

            EmpleadoServicesController oServices = new EmpleadoServicesController();
            try
            {
                if (Constantes.Cero != oEmpleadoViewModel.EntityEmpleado.Key.IDEmpleado)
                {
                    oServices.Update(oEmpleadoViewModel.EntityEmpleado);
                }
                else
                {
                    oServices.Insert(oEmpleadoViewModel.EntityEmpleado);
                }
            }
            catch (Exception)
            {
                resultado[0] = "false";
                resultado[1] = Constantes.GuardadoNoExitoso;
            }


            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        


    }
}
