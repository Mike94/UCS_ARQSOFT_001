using SGI.MVCCliente.Controllers.Filters;
using SGI.MVCCliente.Helpers;
using SGI.MVCCliente.ServicesControllers;
using SGI.MVCCliente.ViewModel;
using SGI.Proxy.Services.TiendaServices;
using SGI.Proxy.Services.UbigeoServices;
using SGI.Proxy.Services.UsuarioServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SGI.MVCCliente.Controllers
{
    public class TiendaController : Controller
    {
        [RequiresAuthenticationAttribute]
        public ActionResult Index(TiendaViewModel oTiendaViewModel)
        {
            oTiendaViewModel.EntityTiendaPaginacion = new EntityTiendaPaginacion { Estado = Constantes.UnoNegativo };
            oTiendaViewModel.ListTiendaPaginado = new List<EntityTiendaPaginacion>();
            return View(oTiendaViewModel);
        }

        public ActionResult TiendaGridPV(TiendaViewModel oTiendaViewModel, Int32 pageIndex)
        {
            TiendaServicesController oServices = new TiendaServicesController();

            if (null == oTiendaViewModel.EntityTiendaPaginacion.EntityPaginacion)
            {
                oTiendaViewModel.EntityTiendaPaginacion.EntityPaginacion = new SGI.Proxy.Services.TiendaServices.EntityPaginacion();
                oTiendaViewModel.EntityTiendaPaginacion.EntityPaginacion.PageIndex = (pageIndex != Constantes.Cero) ? pageIndex : Constantes.PageIndex;
                oTiendaViewModel.EntityTiendaPaginacion.EntityPaginacion.RowsPerPage = Constantes.RowsPerPage;
            }

            EntityTiendaPaginacion oEntityTiendaPaginacion = oTiendaViewModel.EntityTiendaPaginacion;

            IList<EntityTiendaPaginacion> oListTienda = oServices.SelectPagging(ref oEntityTiendaPaginacion);

            oTiendaViewModel.ListTiendaPaginado = oListTienda;
            oTiendaViewModel.EntityTiendaPaginacion = oEntityTiendaPaginacion;

            return PartialView(Constantes.TiendaGridPV, oTiendaViewModel);
        }

        public ActionResult InnerEdit(KeyTienda key)
        {
            return Edit(key);
        }

        public ActionResult Add()
        {
            return Edit(new KeyTienda { CodTienda= Constantes.CadenaVacio });
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(KeyTienda oKey)
        {
            TiendaServicesController oServices = new TiendaServicesController();
            UbigeoServicesController oUbigeoServices = new UbigeoServicesController();
            UsuarioServicesController oUsuarioServices = new UsuarioServicesController();

            TiendaViewModel oTiendaViewModel = new TiendaViewModel();

            EntityTienda oEntityTienda = oServices.SelectByKey(oKey);

            oTiendaViewModel.EntityTienda = oEntityTienda;

            if (String.IsNullOrEmpty(oEntityTienda.Key.CodTienda))
            {

                oTiendaViewModel.ListDepartamento = oUbigeoServices.SelectDepartamento
                (new EntityDepartamento
                {
                    Key = new KeyDepartamento
                    {
                        IdDepartamento = Constantes.CadenaVacio
                    },
                    Estado = Constantes.Activo
                });

                oTiendaViewModel.ListProvincia = oUbigeoServices.SelectProvincia
                (new EntityProvincia
                {
                    Key = new KeyProvincia
                    {
                        IdDepartamento = Constantes.CadenaVacio,
                        IdProvincia = Constantes.CadenaSeleccione
                    },
                    Estado = Constantes.Activo
                });


                oTiendaViewModel.ListDistrito = oUbigeoServices.SelectDistrito
                (new EntityDistrito
                {
                    Key = new KeyDistrito
                    {
                        IdDepartamento = Constantes.CadenaVacio,
                        IdProvincia = Constantes.CadenaSeleccione,
                        IdDistrito = Constantes.CadenaSeleccione
                    },
                    Estado = Constantes.Activo
                });
            }
            else
            {
                oTiendaViewModel.ListDepartamento = oUbigeoServices.SelectDepartamento
                (new EntityDepartamento
                {
                    Key = new KeyDepartamento
                    {
                        IdDepartamento = oTiendaViewModel.EntityTienda.IdRegion
                    },
                    Estado = Constantes.Activo
                });

                oTiendaViewModel.ListProvincia = oUbigeoServices.SelectProvincia
                (new EntityProvincia
                {
                    Key = new KeyProvincia
                    {
                        IdDepartamento = oTiendaViewModel.EntityTienda.IdRegion,
                        IdProvincia = oTiendaViewModel.EntityTienda.IdProvincia
                    },
                    Estado = Constantes.Activo
                });


                oTiendaViewModel.ListDistrito = oUbigeoServices.SelectDistrito
                (new EntityDistrito
                {
                    Key = new KeyDistrito
                    {
                        IdDepartamento = oTiendaViewModel.EntityTienda.IdRegion,
                        IdProvincia = oTiendaViewModel.EntityTienda.IdProvincia,
                        IdDistrito = oTiendaViewModel.EntityTienda.IdDistrito
                    },
                    Estado = Constantes.Activo
                });
            }

            return PartialView(Constantes.TiendaEdit, oTiendaViewModel);
        }

        public PartialViewResult UbigeoPV(TiendaViewModel oTiendaViewModel)
        {
            UbigeoServicesController oUbigeoServices = new UbigeoServicesController();

            String departamento = oTiendaViewModel.EntityTienda.IdRegion;
            String provincia = oTiendaViewModel.EntityTienda.IdProvincia;
            String distrito = oTiendaViewModel.EntityTienda.IdDistrito;

            departamento = (String.IsNullOrEmpty(departamento)) ? Constantes.CadenaVacio : departamento;
            provincia = (String.IsNullOrEmpty(provincia)) ? Constantes.CadenaVacio : provincia;
            distrito = (String.IsNullOrEmpty(distrito)) ? Constantes.CadenaVacio : distrito;

            oTiendaViewModel.ListDepartamento = oUbigeoServices.SelectDepartamento
            (new EntityDepartamento
            {
                Key = new KeyDepartamento
                {
                    IdDepartamento = Constantes.CadenaVacio
                },
                Estado = Constantes.Activo
            });


            oTiendaViewModel.ListProvincia = oUbigeoServices.SelectProvincia
            (new EntityProvincia
            {
                Key = new KeyProvincia
                {
                    IdDepartamento = departamento,
                    IdProvincia = provincia
                },
                Estado = Constantes.Activo
            });


            oTiendaViewModel.ListDistrito = oUbigeoServices.SelectDistrito
            (new EntityDistrito
            {
                Key = new KeyDistrito
                {
                    IdDepartamento = departamento,
                    IdProvincia = provincia,
                    IdDistrito = distrito
                },
                Estado = Constantes.Activo
            });

            oTiendaViewModel.EntityTienda.IdRegion = departamento;
            oTiendaViewModel.EntityTienda.IdProvincia = provincia;
            oTiendaViewModel.EntityTienda.IdDistrito = distrito;

            return PartialView(Constantes.UbigeoPV, oTiendaViewModel);
        }

        public JsonResult Guardar(TiendaViewModel oTiendaViewModel)
        {
            List<String> resultado = new List<String>();
            resultado.Add("true");
            resultado.Add(Constantes.GuardadoExitoso);

            TiendaServicesController oServices = new TiendaServicesController();
            try
            {
                EntityTienda oEntityTiendaExists = oServices.SelectByKey(oTiendaViewModel.EntityTienda.Key);

                if (Constantes.CadenaVacio != oEntityTiendaExists.Key.CodTienda)
                {
                    oServices.Update(oTiendaViewModel.EntityTienda);
                }
                else
                {
                    oServices.Insert(oTiendaViewModel.EntityTienda);
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
