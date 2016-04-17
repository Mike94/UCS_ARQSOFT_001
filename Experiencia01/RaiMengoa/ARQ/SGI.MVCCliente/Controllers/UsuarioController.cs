using SGI.MVCCliente.Controllers.Filters;
using SGI.MVCCliente.Helpers;
using SGI.MVCCliente.ServicesControllers;
using SGI.MVCCliente.ViewModel;
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
    public class UsuarioController : Controller
    {
        public JsonResult Guardar(UsuarioViewModel oUsuarioViewModel)
        {
            List<String> resultado = new List<String>();
            resultado.Add("true");
            resultado.Add(Constantes.GuardadoExitoso);

            UsuarioServicesController oServices = new UsuarioServicesController();
            try
            {
                EntityUsuario oEntityUsuarioExists = oServices.SelectByKey(oUsuarioViewModel.EntityUsuario.Key);

                if (Constantes.Cero != oEntityUsuarioExists.Key.IDUsuario)
                {
                    oServices.Update(oUsuarioViewModel.EntityUsuario);
                }
                else
                {
                    oServices.Insertar(oUsuarioViewModel.EntityUsuario);
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
