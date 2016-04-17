using SGI.MVCCliente.Controllers.Filters;
using SGI.MVCCliente.Helpers;
using SGI.MVCCliente.ServicesControllers;
using SGI.MVCCliente.ViewModel;
using SGI.Proxy.Services.PedidoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pg = SGI.Proxy.Services.GrupoServices;
using Pp = SGI.Proxy.Services.ProductoServices;
using Pe = SGI.Proxy.Services.EmpresaServices;
using SGI.Proxy.Services.UsuarioServices;

namespace SGI.MVCCliente.Controllers
{
    public class PedidoController : Controller
    {
        GrupoServicesController oGrupoServices = new GrupoServicesController();
        ProductoServicesController oProductoServices = new ProductoServicesController();

        [RequiresAuthenticationAttribute]
        public ActionResult Index()
        {
            return View();
        }

        [RequiresAuthenticationAttribute]
        public ActionResult Generar(PedidoViewModel oPedidoViewModel)
        {
            // LIMPIAR LAS VARIABLES DE SESION
            Session["EntityPedido"] = null;
            Session["ListDetallePedido"] = null;

            EmpresaServicesController oEmpresaServices = new EmpresaServicesController();

            IList<Pe.EntityEmpresa> oListEmpresa = oEmpresaServices.Select(
                new Pe.EntityEmpresa
                {
                    Estado = Constantes.Activo
                });

            oPedidoViewModel.ListEmpresa = oListEmpresa;

            return View(oPedidoViewModel);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public PartialViewResult CabeceraGenerarPV(PedidoViewModel oPedidoViewModel)
        {
            if (null == oPedidoViewModel.EntityPedido.Key)
            {
                PedidoServicesController oPedidoServices = new PedidoServicesController();

                //Obtenemos el último Pedido
                IList<EntityPedido> ListPedidos = oPedidoServices.Select(new EntityPedido { Key = new KeyPedido(), Estado = Constantes.Activo });


                String codigoPedido = DateTime.Now.ToString("yyyyMMdd-H:mm:ss");
                Int32 numPedido = 0;
                if (ListPedidos.Count > Constantes.Uno)
                {
                    String codigoTemp = codigoPedido;
                    ListPedidos = ListPedidos.Where(n => n.CodigoPedido.Contains(codigoTemp)).ToList();

                    if (ListPedidos.Count > Constantes.Uno)
                    {
                        numPedido = ListPedidos.Last().Key.IDPedido + 10;
                    }
                }
                codigoPedido = "PE" + codigoPedido + "-" + numPedido;

                oPedidoViewModel.EntityPedido.Key = new KeyPedido();
                oPedidoViewModel.EntityPedido.CodigoPedido = codigoPedido;

                // Muestra el combo de empresa
                EmpresaServicesController oEmpresaServices = new EmpresaServicesController();

                IList<Pe.EntityEmpresa> oListEmpresa = oEmpresaServices.Select(
                    new Pe.EntityEmpresa
                    {
                        Estado = Constantes.Activo
                    });

                oPedidoViewModel.ListEmpresa = oListEmpresa;

                Session["EntityPedido"] = oPedidoViewModel.EntityPedido;
            }
            return PartialView(Constantes.CabeceraGenerarPV, oPedidoViewModel);
        }

        public PartialViewResult EditProductoPedidoPV(Int32 oIDProducto, Int32 opcion)
        {
            ProductoViewModel oProductoViewModel = new ProductoViewModel();
            oProductoViewModel.EntityProducto = new Pp.EntityProducto
            {
                Key = new Pp.KeyProducto { IDProducto = oIDProducto }
            };
            ViewData["Opcion"] = opcion;

            return PartialView(Constantes.EditProductoPedidoPV, oProductoViewModel);
        }

        public PartialViewResult PedidoGenerarPV(PedidoViewModel oPedidoViewModel, int idGrupo, int pageIndex)
        {
            ProductoServicesController oServices = new ProductoServicesController();
            GrupoViewModel oGrupoViewModel = new GrupoViewModel();
            ProductoViewModel oProductoViewModel = new ProductoViewModel();

            oPedidoViewModel.GrupoViewModel = oGrupoViewModel;
            Pg.EntityGrupo oEntityGrupo = new Pg.EntityGrupo()
            {
                Key = new Pg.KeyGrupo { IDGrupo = Constantes.UnoNegativo },
                Estado = Constantes.Activo
            };

            oPedidoViewModel.GrupoViewModel.EntityGrupo = oEntityGrupo;
            oPedidoViewModel.GrupoViewModel.ListGrupo = oGrupoServices.Select(oEntityGrupo);

            oGrupoServices.Select(oEntityGrupo);

            if (null == oPedidoViewModel.ProductoViewModel)
            {
                oPedidoViewModel.ProductoViewModel = oProductoViewModel;
                oPedidoViewModel.ProductoViewModel.EntityProductoPaginacion = new Pp.EntityProductoPaginacion();
                oPedidoViewModel.ProductoViewModel.EntityProductoPaginacion.IdGrupo = idGrupo;
            }
            else
            {
                oPedidoViewModel.ProductoViewModel.EntityProductoPaginacion = new Pp.EntityProductoPaginacion();
                oPedidoViewModel.ProductoViewModel.EntityProductoPaginacion.IdGrupo = idGrupo;
            }

            if (null == oPedidoViewModel.ProductoViewModel.EntityProductoPaginacion.EntityPaginacion)
            {
                oPedidoViewModel.ProductoViewModel.EntityProductoPaginacion.Estado = Constantes.Activo;
                oPedidoViewModel.ProductoViewModel.EntityProductoPaginacion.EntityPaginacion = new SGI.Proxy.Services.ProductoServices.EntityPaginacion();
                oPedidoViewModel.ProductoViewModel.EntityProductoPaginacion.EntityPaginacion.PageIndex = (pageIndex != Constantes.Cero) ? pageIndex : Constantes.PageIndex;
                oPedidoViewModel.ProductoViewModel.EntityProductoPaginacion.EntityPaginacion.RowsPerPage = Constantes.RowsPerPage;
            }
            oProductoViewModel = oPedidoViewModel.ProductoViewModel;

            Pp.EntityProductoPaginacion oEntityProductoPaginacion = oProductoViewModel.EntityProductoPaginacion;

            IList<Pp.EntityProductoPaginacion> oListProducto = oServices.SelectPagging(ref oEntityProductoPaginacion);

            oProductoViewModel.ListProductoPaginado = oListProducto;
            oProductoViewModel.EntityProductoPaginacion = oEntityProductoPaginacion;
            oPedidoViewModel.ProductoViewModel = oProductoViewModel;

            return PartialView(Constantes.PedidoGenerarPV, oPedidoViewModel);
        }


        //Generar PDF
        public ActionResult GenerarPDF() 
        {
            GeneratePDF oGenerar = new GeneratePDF();
            List<EntityDetallePedido> oListDetallePedido = (List<EntityDetallePedido>)Session["ListDetallePedido"];
            if (null == Session["ListDetallePedido"])
            {
                oListDetallePedido = new List<EntityDetallePedido>();
            }
            try
            {
                oGenerar.CreatePDF("VistaPreviaPDF", "VPPDF", oListDetallePedido.ToList(), Response);
            }
            catch (Exception)
            {
               
            }
            return null;
        }



        public JsonResult PedidoProductoGuardar(ProductoViewModel oProductoViewModel, Int32 opcion)
        {
            List<String> resultado = new List<String>();
            resultado.Add("true");
            resultado.Add(Constantes.GuardadoExitoso);

            if (null == Session["ListDetallePedido"])
            {
                Session["ListDetallePedido"] = new List<EntityDetallePedido>();
            }
            
            EntityDetallePedido oEntityDetallePedido =
            new EntityDetallePedido
            {
                Key = new KeyDetallePedido { IDProducto = oProductoViewModel.EntityProducto.Key.IDProducto }
            };

            oEntityDetallePedido.Cantidad = oProductoViewModel.EntityProducto.Cantidadinventario;
            List<EntityDetallePedido> oListDetallePedido = (List<EntityDetallePedido>)Session["ListDetallePedido"];

            try
            {
                        Int32 registroExistente = oListDetallePedido.Where(n => n.Key.IDProducto == oEntityDetallePedido.Key.IDProducto).Count();
                        if (registroExistente == Constantes.Cero && opcion == Constantes.Uno)
                        {
                            oListDetallePedido.Add(oEntityDetallePedido);
                        }
                        else
                        {
                            if (registroExistente == Constantes.Cero && opcion == Constantes.Dos)
                            {
                                resultado[0] = "false";
                                resultado[1] = Constantes.PedidoInvalidadoCantidad;
                            }
                            else
                            {
                                EntityDetallePedido oTempEntityDetallePedido = oListDetallePedido.Where(n => n.Key.IDProducto == oEntityDetallePedido.Key.IDProducto).First();
                                switch (opcion)
                                {
                                    case 1:
                                        oEntityDetallePedido.Cantidad = oEntityDetallePedido.Cantidad + oTempEntityDetallePedido.Cantidad;
                                        break;
                                    case 2:
                                        if (oEntityDetallePedido.Cantidad > oTempEntityDetallePedido.Cantidad)
                                        {
                                            resultado[0] = "false";
                                            resultado[1] = Constantes.PedidoInvalidadoCantidad;
                                        }
                                        else
                                        {
                                            oEntityDetallePedido.Cantidad = oTempEntityDetallePedido.Cantidad - oEntityDetallePedido.Cantidad;
                                            oListDetallePedido.Remove(oTempEntityDetallePedido);
                                            oListDetallePedido.Add(oEntityDetallePedido);
                                        }
                                        break;
                                } 
                            }
                             
                        }

               
            }
            catch (Exception)
            {
                resultado[0] = "false";
                resultado[1] = Constantes.GuardadoNoExitoso;
            }

            Session["ListDetallePedido"] = oListDetallePedido;

            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public JsonResult PedidoCompletoGuardar()
        {
            List<String> resultado = new List<String>();
            resultado.Add("true");
            resultado.Add(Constantes.PedidoGuardadoExitoso);

            PedidoServicesController oPedidoServices = new PedidoServicesController();

            try
            {
                if (null == Session["ListDetallePedido"])
                {
                    resultado[0] = "false";
                    resultado[1] = Constantes.PedidoNoTieneRegistros;
                }
                else
                {
                    List<EntityDetallePedido> ListDetallePedido = (List<EntityDetallePedido>)Session["ListDetallePedido"];
                    EntityPedido oEntityPedido = (EntityPedido)Session["EntityPedido"];
                    oEntityPedido.IDEncargado = ((EntityUsuario)Session["Usuario"]).Key.IDUsuario;

                    Int32 result = oPedidoServices.InsertPedidoCompleto(oEntityPedido, ListDetallePedido);
                    if (result != Constantes.Uno)
	                {
                        resultado[0] = "false";
                        resultado[1] = Constantes.PedidoNoGuardadoExitoso;
                    }
                    else
                    {
                        // LIMPIAR LAS VARIABLES DE SESION
                        Session["EntityPedido"] = null;
                        Session["ListDetallePedido"] = null;
                    }
                }
            }
            catch (Exception)
            {
                resultado[0] = "false";
                resultado[1] = Constantes.PedidoNoGuardadoExitoso;
            }

            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        [RequiresAuthenticationAttribute]
        public ActionResult Seguimiento()
        {
            return View();
        }

        [RequiresAuthenticationAttribute]
        public ActionResult Cierre()
        {
            return View();
        }

    }
}
