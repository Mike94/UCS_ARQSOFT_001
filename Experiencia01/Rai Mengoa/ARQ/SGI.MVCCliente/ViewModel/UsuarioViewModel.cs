using SGI.Proxy.Services.UsuarioServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ViewModel
{
    public class UsuarioViewModel
    {
        public EntityUsuario EntityUsuario { get; set; }

        private String reClave;
        public String ReClave
        {
            get { return EntityUsuario.Clave; }
            set { reClave = value; }
        }
        
    }
}