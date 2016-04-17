using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SGI.MVCCliente.Helpers
{
    public class SessionHelper
    {
        private static String nombreUsuario = Constantes.CadenaVacio;

        public static String NombreUsuario
        {
            get { return String.Format("Bienvenido : {0}", nombreUsuario); }
            set { nombreUsuario = value; }
        }

        public static String Ribbon(Uri oUri)
        {
            StringBuilder oStringBuilder = new StringBuilder();

            oStringBuilder.Append("<ol class=\"breadcrumb\">");
            for (int i = 1; i < oUri.Segments.Length; i++)
            {
                String segment = oUri.Segments[i].Replace("/", "");
                oStringBuilder.Append(String.Format("<li> {0} </li>", segment));
            }
            
            oStringBuilder.Append("</ol>");

            return oStringBuilder.ToString();
        }
    }
}