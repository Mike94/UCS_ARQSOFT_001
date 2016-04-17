using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SGISystem.Services.Contracts
{
    [ServiceContract]
    public interface IUsuarioServices
    {
        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Autenticar",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        Boolean Autenticar(EntityUsuario oEntityUsuario);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Insert",
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityUsuario Insert(EntityUsuario oEntityUsuario);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Update",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityUsuario Update(EntityUsuario oEntityUsuario);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Delete",
            Method = "DELETE",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityUsuario Delete(EntityUsuario oEntityUsuario);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectByKey",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityUsuario SelectByKey(KeyUsuario oKeyUsuario);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Select",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityUsuario> Select(EntityUsuario oEntityUsuario);

        [OperationContract]
        [WebInvoke
        (UriTemplate = "/SelectPagging",
        Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped)]
        IList<EntityUsuarioPaginacion> SelectPagging(ref EntityUsuarioPaginacion oEntityUsuarioPaginacion);
    }
}
