using SGISystem.Domain.Entities;
using System;
using System.Collections.Generic;
using SGISystem.Domain.Entities.Keys;
using System.Linq;
using System.Net.Security;
using System.ServiceModel;
using System.ServiceModel.Web;
using SGISystem.Domain.Entities.Pagination;

namespace SGISystem.Services.Contracts
{
    [ServiceContract]
    public interface IPedidoServices
    {

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectByKey",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityPedido SelectByKey(KeyPedido oKeyPedido);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Select",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityPedido> Select(EntityPedido oEntityPedido);

        [OperationContract]
        [WebInvoke
        (UriTemplate = "/SelectPagging",
        Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped)]
        IList<EntityPedidoPaginacion> SelectPagging(ref EntityPedidoPaginacion oEntityPedidoPaginacion);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Insert",
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityPedido Insert(EntityPedido oEntityPedido);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Update",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityPedido Update(EntityPedido oEntityPedido);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Delete",
            Method = "DELETE",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityPedido Delete(EntityPedido oEntityPedido);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/InsertPedidoCompleto",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 InsertPedidoCompleto(EntityPedido oEntityPedido, List<EntityDetallePedido> oListDetallePedido);

    }
}
