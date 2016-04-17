using SGI.MVCCliente.ServicesControllers;
using SGI.MVCCliente.ViewModel;
using SGI.MVCCliente.ViewModels;
using SGI.Proxy.Services.UsuarioServices;
using System;
using System.Security.Principal;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Linq;
using SGI.MVCCliente.Helpers;

namespace SGI.MVCCliente.Controllers
{
    public class CuentaController : Controller
    {
        public IFormsAuthenticationService FormsService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (FormsService == null) { FormsService = new FormsAuthenticationService(); }

            base.Initialize(requestContext);
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }

        public ActionResult IniciarSesion(String stringUrl)
        {
            ViewData["stringUrl"] = (stringUrl == null) ? "/" : stringUrl;
            return View();
        }

        //En caso de errores
        public ActionResult IngresarSesion()
        {
            return RedirectToAction("IniciarSesion", "Cuenta");
        }

        [HttpPost]
        public ActionResult IngresarSesion(String usuario, String clave, String stringUrl)
        
        {
            if (String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(clave))
            {
                return RedirectToAction("IniciarSesion", "Cuenta");
            }
            else
            {
                UsuarioServicesController oUsuarioServices = new UsuarioServicesController();
                EntityUsuario oEntityUsuario = new EntityUsuario();
                oEntityUsuario.Usuario = usuario;
                oEntityUsuario.Clave = clave;
                Boolean valido = oUsuarioServices.AutenticarUsuario(oEntityUsuario);

                if (valido)
                {
                    FormsService.SignIn(usuario, false);

                    Session["Usuario"] = oUsuarioServices.Select(oEntityUsuario).First();
                    SessionHelper.NombreUsuario = oEntityUsuario.Usuario;

                    //GENERAR MENU

                    String redirect = FormsAuthentication.GetRedirectUrl(usuario, false);
                    if (!String.IsNullOrEmpty(stringUrl))
                    {
                        redirect = (stringUrl == "/") ? redirect : "~" + stringUrl; 
                    }

                    return Redirect(redirect);
                }
                else
                {
                    return RedirectToAction("IniciarSesion", "Cuenta");
                }
            } 
        }


        public ActionResult CerrarSesion()
        {
            FormsService.SignOut();
            Session.RemoveAll();
            return RedirectToAction("IniciarSesion", "Cuenta");
        }
    }
}
