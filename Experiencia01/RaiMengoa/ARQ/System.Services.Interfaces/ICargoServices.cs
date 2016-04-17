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
    public interface ICargoServices
    {

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectByKey",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityCargo SelectByKey(KeyCargo oKeyCargo);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Select",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityCargo> Select(EntityCargo oEntityCargo);

        [OperationContract]
        [WebInvoke
        (UriTemplate = "/SelectPagging",
        Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped)]
        IList<EntityCargoPaginacion> SelectPagging(ref EntityCargoPaginacion oEntityCargoPaginacion);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Insert",
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityCargo Insert(EntityCargo oEntityCargo);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Update",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityCargo Update(EntityCargo oEntityCargo);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Delete",
            Method = "DELETE",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityCargo Delete(EntityCargo oEntityCargo);

    }
}
