using SGI.MVCCliente.Controllers.Filters;
using SGI.MVCCliente.Helpers;
using SGI.MVCCliente.ServicesControllers;
using SGI.MVCCliente.ViewModel;
using SGI.Proxy.Services.GrupoServices;
using SGI.Proxy.Services.ProductoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGI.MVCCliente.Controllers
{
    public class ProductoController : Controller
    {
        [RequiresAuthenticationAttribute]
        public ActionResult Index(ProductoViewModel oProductoViewModel)
        {
            oProductoViewModel.EntityProductoPaginacion = new EntityProductoPaginacion { Estado = Constantes.UnoNegativo };
            oProductoViewModel.ListProductoPaginado = new List<EntityProductoPaginacion>();
            return View(oProductoViewModel);
        }

        public ActionResult ProductoGridPV(ProductoViewModel oProductoViewModel, Int32 pageIndex)
         {
             ProductoServicesController oServices = new ProductoServicesController();

             if (null == oProductoViewModel.EntityProductoPaginacion.EntityPaginacion)
             {
                 oProductoViewModel.EntityProductoPaginacion.IdGrupo = Constantes.UnoNegativo; // Indica que no se filtra por grupo
                 oProductoViewModel.EntityProductoPaginacion.EntityPaginacion = new SGI.Proxy.Services.ProductoServices.EntityPaginacion();
                 oProductoViewModel.EntityProductoPaginacion.EntityPaginacion.PageIndex = (pageIndex != Constantes.Cero) ? pageIndex : Constantes.PageIndex;
                 oProductoViewModel.EntityProductoPaginacion.EntityPaginacion.RowsPerPage = Constantes.RowsPerPage;
             }

             EntityProductoPaginacion oEntityProductoPaginacion = oProductoViewModel.EntityProductoPaginacion;

             IList<EntityProductoPaginacion> oListProducto = oServices.SelectPagging(ref oEntityProductoPaginacion);

             oProductoViewModel.ListProductoPaginado = oListProducto;
             oProductoViewModel.EntityProductoPaginacion = oEntityProductoPaginacion;

             return PartialView(Constantes.ProductoGridPV, oProductoViewModel);
         }

        public ActionResult Add()
        {
            return Edit(new KeyProducto());
        }

        public ActionResult InnerEdit(KeyProducto key)
        {
            return Edit(key);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(KeyProducto key)
        {
            ProductoServicesController oServices = new ProductoServicesController();
            GrupoServicesController oGrupoServices = new GrupoServicesController();

            EntityProducto oEntityProducto = oServices.SelectByKey(key);

            ProductoViewModel oProductoViewModel = new ProductoViewModel();
            oProductoViewModel.EntityProducto = oEntityProducto;

            oProductoViewModel.ListGrupo = oGrupoServices.Select
                (new EntityGrupo
                {
                    IDGrupoPadre = Constantes.UnoNegativo,
                    Key = new KeyGrupo { IDGrupo = Constantes.UnoNegativo }
                }
                );

            oProductoViewModel.EditableCantidadinventario = Constantes.Falso;

            return PartialView(Constantes.ProductoEdit, oProductoViewModel);
        }

        public JsonResult  GuardarProducto(ProductoViewModel oProductoViewModel)
        {
            List<String> resultado = new List<String>();
            resultado.Add("true");
            resultado.Add(Constantes.GuardadoExitoso);

            ProductoServicesController oServices = new ProductoServicesController();
            try
            {
                EntityProducto oEntityProductoExists = oServices.SelectByKey(oProductoViewModel.EntityProducto.Key);

                if (Constantes.Cero != oEntityProductoExists.Key.IDProducto)
                {
                    oServices.Update(oProductoViewModel.EntityProducto);
                }
                else
                {
                    oServices.AgregarProducto(oProductoViewModel.EntityProducto);
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
