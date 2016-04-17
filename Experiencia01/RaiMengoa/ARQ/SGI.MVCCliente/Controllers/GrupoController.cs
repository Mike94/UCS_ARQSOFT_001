using SGI.MVCCliente.Controllers.Filters;
using SGI.MVCCliente.Helpers;
using SGI.MVCCliente.ServicesControllers;
using SGI.MVCCliente.ViewModel;
using SGI.Proxy.Services.GrupoServices;
using SGI.Proxy.Services.UsuarioServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SGI.MVCCliente.Controllers
{
    public class GrupoController : Controller
    {
        [RequiresAuthenticationAttribute]
        public ActionResult Index(GrupoViewModel oGrupoViewModel)
        {
            oGrupoViewModel.EntityGrupoPaginacion = new EntityGrupoPaginacion { Estado = Constantes.UnoNegativo };
            oGrupoViewModel.ListGrupoPaginado = new List<EntityGrupoPaginacion>();
            return View(oGrupoViewModel);
        }

        public ActionResult GrupoGridPV(GrupoViewModel oGrupoViewModel, Int32 pageIndex)
        {
            GrupoServicesController oServices = new GrupoServicesController();

            if (null == oGrupoViewModel.EntityGrupoPaginacion.EntityPaginacion)
            {
                oGrupoViewModel.EntityGrupoPaginacion.EntityPaginacion = new SGI.Proxy.Services.GrupoServices.EntityPaginacion();
                oGrupoViewModel.EntityGrupoPaginacion.EntityPaginacion.PageIndex = (pageIndex != Constantes.Cero) ? pageIndex : Constantes.PageIndex;
                oGrupoViewModel.EntityGrupoPaginacion.EntityPaginacion.RowsPerPage = Constantes.RowsPerPage;
            }

            EntityGrupoPaginacion oEntityGrupoPaginacion = oGrupoViewModel.EntityGrupoPaginacion;

            IList<EntityGrupoPaginacion> oListGrupo = oServices.SelectPagging(ref oEntityGrupoPaginacion);

            oGrupoViewModel.ListGrupoPaginado = oListGrupo;
            oGrupoViewModel.EntityGrupoPaginacion = oEntityGrupoPaginacion;

            return PartialView(Constantes.GrupoGridPV, oGrupoViewModel);
        }

        public ActionResult InnerEdit(KeyGrupo key)
        {
            return Edit(key);
        }

        public ActionResult Add()
        {
            return Edit(new KeyGrupo ());
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(KeyGrupo oKey)
        {
            GrupoServicesController oServices = new GrupoServicesController();
            UsuarioServicesController oUsuarioServices = new UsuarioServicesController();

            GrupoViewModel oGrupoViewModel = new GrupoViewModel();

            EntityGrupo oEntityGrupo = oServices.SelectByKey(oKey);

            oGrupoViewModel.EntityGrupo = oEntityGrupo;
            oGrupoViewModel.ListGrupo = oServices.Select
                (new EntityGrupo
                {
                    IDGrupoPadre = Constantes.UnoNegativo,
                    Key = new KeyGrupo { IDGrupo = Constantes.UnoNegativo }
                }
                );
            return PartialView(Constantes.GrupoEdit, oGrupoViewModel);
        }

        public JsonResult Guardar(GrupoViewModel oGrupoViewModel)
        {
            List<String> resultado = new List<String>();
            resultado.Add("true");
            resultado.Add(Constantes.GuardadoExitoso);

            GrupoServicesController oServices = new GrupoServicesController();
            try
            {
                EntityGrupo oEntityGrupoExists = oServices.SelectByKey(oGrupoViewModel.EntityGrupo.Key);

                if (Constantes.Cero != oEntityGrupoExists.Key.IDGrupo)
                {
                    oServices.Update(oGrupoViewModel.EntityGrupo);
                }
                else
                {
                    oServices.Insert(oGrupoViewModel.EntityGrupo);
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
