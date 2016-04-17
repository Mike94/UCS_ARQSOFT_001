using SGI.MVCCliente.Controllers.Filters;
using SGI.MVCCliente.Helpers;
using SGI.MVCCliente.ServicesControllers;
using SGI.MVCCliente.ViewModel;
using SGI.Proxy.Services.CargoServices;
using SGI.Proxy.Services.UsuarioServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SGI.MVCCliente.Controllers
{
    public class CargoController : Controller
    {
        [RequiresAuthenticationAttribute]
        public ActionResult Index(CargoViewModel oCargoViewModel)
        {
            oCargoViewModel.EntityCargoPaginacion = new EntityCargoPaginacion { Estado = Constantes.UnoNegativo };
            oCargoViewModel.ListCargoPaginado = new List<EntityCargoPaginacion>();
            return View(oCargoViewModel);
        }

        public ActionResult CargoGridPV(CargoViewModel oCargoViewModel, Int32 pageIndex)
        {
            CargoServicesController oServices = new CargoServicesController();

            if (null == oCargoViewModel.EntityCargoPaginacion.EntityPaginacion)
            {
                oCargoViewModel.EntityCargoPaginacion.EntityPaginacion = new SGI.Proxy.Services.CargoServices.EntityPaginacion();
                oCargoViewModel.EntityCargoPaginacion.EntityPaginacion.PageIndex = (pageIndex != Constantes.Cero) ? pageIndex : Constantes.PageIndex;
                oCargoViewModel.EntityCargoPaginacion.EntityPaginacion.RowsPerPage = Constantes.RowsPerPage;
            }

            EntityCargoPaginacion oEntityCargoPaginacion = oCargoViewModel.EntityCargoPaginacion;

            IList<EntityCargoPaginacion> oListCargo = oServices.SelectPagging(ref oEntityCargoPaginacion);

            oCargoViewModel.ListCargoPaginado = oListCargo;
            oCargoViewModel.EntityCargoPaginacion = oEntityCargoPaginacion;

            return PartialView(Constantes.CargoGridPV, oCargoViewModel);
        }

        public ActionResult InnerEdit(KeyCargo key)
        {
            return Edit(key);
        }

        public ActionResult Add()
        {
            return Edit(new KeyCargo ());
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(KeyCargo oKey)
        {
            CargoServicesController oServices = new CargoServicesController();
            UsuarioServicesController oUsuarioServices = new UsuarioServicesController();

            CargoViewModel oCargoViewModel = new CargoViewModel();

            EntityCargo oEntityCargo = oServices.SelectByKey(oKey);

            oCargoViewModel.EntityCargo = oEntityCargo;

            return PartialView(Constantes.CargoEdit, oCargoViewModel);
        }

        public JsonResult Guardar(CargoViewModel oCargoViewModel)
        {
            List<String> resultado = new List<String>();
            resultado.Add("true");
            resultado.Add(Constantes.GuardadoExitoso);

            CargoServicesController oServices = new CargoServicesController();
            try
            {
                EntityCargo oEntityCargoExists = oServices.SelectByKey(oCargoViewModel.EntityCargo.Key);

                if (Constantes.Cero != oEntityCargoExists.Key.IDCargo)
                {
                    oServices.Update(oCargoViewModel.EntityCargo);
                }
                else
                {
                    oServices.Insert(oCargoViewModel.EntityCargo);
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
