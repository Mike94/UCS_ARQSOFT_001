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
    public interface IDetallePedidoServices
    {

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectByKey",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityDetallePedido SelectByKey(KeyDetallePedido oKeyDetallePedido);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Select",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityDetallePedido> Select(EntityDetallePedido oEntityDetallePedido);

        [OperationContract]
        [WebInvoke
        (UriTemplate = "/SelectPagging",
        Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped)]
        IList<EntityDetallePedidoPaginacion> SelectPagging(ref EntityDetallePedidoPaginacion oEntityDetallePedidoPaginacion);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Insert",
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityDetallePedido Insert(EntityDetallePedido oEntityDetallePedido);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Update",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityDetallePedido Update(EntityDetallePedido oEntityDetallePedido);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Delete",
            Method = "DELETE",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityDetallePedido Delete(EntityDetallePedido oEntityDetallePedido);
    }
}
