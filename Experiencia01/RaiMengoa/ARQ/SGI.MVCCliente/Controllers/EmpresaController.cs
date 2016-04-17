using SGI.MVCCliente.Controllers.Filters;
using SGI.MVCCliente.Helpers;
using SGI.MVCCliente.ServicesControllers;
using SGI.MVCCliente.ViewModel;
using SGI.Proxy.Services.EmpresaServices;
using SGI.Proxy.Services.UsuarioServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SGI.MVCCliente.Controllers
{
    public class EmpresaController : Controller
    {
        [RequiresAuthenticationAttribute]
        public ActionResult Index(EmpresaViewModel oEmpresaViewModel)
        {
            oEmpresaViewModel.EntityEmpresaPaginacion = new EntityEmpresaPaginacion { Estado = Constantes.UnoNegativo };
            oEmpresaViewModel.ListEmpresaPaginado = new List<EntityEmpresaPaginacion>();
            return View(oEmpresaViewModel);
        }

        public ActionResult EmpresaGridPV(EmpresaViewModel oEmpresaViewModel, Int32 pageIndex)
        {
            EmpresaServicesController oServices = new EmpresaServicesController();

            if (null == oEmpresaViewModel.EntityEmpresaPaginacion.EntityPaginacion)
            {
                oEmpresaViewModel.EntityEmpresaPaginacion.EntityPaginacion = new SGI.Proxy.Services.EmpresaServices.EntityPaginacion();
                oEmpresaViewModel.EntityEmpresaPaginacion.EntityPaginacion.PageIndex = (pageIndex != Constantes.Cero) ? pageIndex : Constantes.PageIndex;
                oEmpresaViewModel.EntityEmpresaPaginacion.EntityPaginacion.RowsPerPage = Constantes.RowsPerPage;
            }

            EntityEmpresaPaginacion oEntityEmpresaPaginacion = oEmpresaViewModel.EntityEmpresaPaginacion;

            IList<EntityEmpresaPaginacion> oListEmpresa = oServices.SelectPagging(ref oEntityEmpresaPaginacion);

            oEmpresaViewModel.ListEmpresaPaginado = oListEmpresa;
            oEmpresaViewModel.EntityEmpresaPaginacion = oEntityEmpresaPaginacion;

            return PartialView(Constantes.EmpresaGridPV, oEmpresaViewModel);
        }

        public ActionResult InnerEdit(KeyEmpresa key)
        {
            return Edit(key);
        }

        public ActionResult Add()
        {
            return Edit(new KeyEmpresa ());
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(KeyEmpresa oKey)
        {
            EmpresaServicesController oServices = new EmpresaServicesController();
            UsuarioServicesController oUsuarioServices = new UsuarioServicesController();

            EmpresaViewModel oEmpresaViewModel = new EmpresaViewModel();

            EntityEmpresa oEntityEmpresa = oServices.SelectByKey(oKey);

            oEmpresaViewModel.EntityEmpresa = oEntityEmpresa;
            oEmpresaViewModel.ListTipoEmpresa = oServices.SelectTipoEmpresa(
                new EntityTipoEmpresa
                {
                    Key = new KeyTipoEmpresa { IDTipoEmpresa = Constantes.UnoNegativo },
                    Estado = Constantes.Activo
                });

            return PartialView(Constantes.EmpresaEdit, oEmpresaViewModel);
        }

        public JsonResult Guardar(EmpresaViewModel oEmpresaViewModel)
        {
            List<String> resultado = new List<String>();
            resultado.Add("true");
            resultado.Add(Constantes.GuardadoExitoso);

            EmpresaServicesController oServices = new EmpresaServicesController();
            try
            {
                EntityEmpresa oEntityEmpresaExists = oServices.SelectByKey(oEmpresaViewModel.EntityEmpresa.Key);

                if (Constantes.Cero != oEntityEmpresaExists.Key.IDEmpresa)
                {
                    oServices.Update(oEmpresaViewModel.EntityEmpresa);
                }
                else
                {
                    oServices.Insert(oEmpresaViewModel.EntityEmpresa);
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
