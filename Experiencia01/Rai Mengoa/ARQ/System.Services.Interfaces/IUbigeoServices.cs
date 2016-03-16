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
    public interface IUbigeoServices
    {
        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectDistrito",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityDistrito> SelectDistrito(EntityDistrito oEntityDistrito);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectProvincia",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityProvincia> SelectProvincia(EntityProvincia oEntityProvincia);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectDepartamento",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityDepartamento> SelectDepartamento(EntityDepartamento oEntityDepartamento);
    }
}
