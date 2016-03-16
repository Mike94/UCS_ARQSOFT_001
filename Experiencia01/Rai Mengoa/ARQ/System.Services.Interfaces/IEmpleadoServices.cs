using SGISystem.Domain.Entities;
using System;
using System.Collections.Generic;
using SGISystem.Domain.Entities.Keys;
using System.Linq;
using System.Net.Security;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;

namespace SGISystem.Services.Contracts
{
    [ServiceContract]
    public interface IEmpleadoServices
    {

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectTest",
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityEmpleado> SelectTest();

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectByKey",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityEmpleado SelectByKey(KeyEmpleado oKeyEmpleado);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Select",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityEmpleado> Select(EntityEmpleado oEntityEmpleado);

        [OperationContract]
        [WebInvoke
        (UriTemplate = "/SelectPagging",
        Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped)]
        IList<EntityEmpleadoPaginacion> SelectPagging(ref EntityEmpleadoPaginacion oEntityEmpleadoPaginacion);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Insert",
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityEmpleado Insert(EntityEmpleado oEntityEmpleado);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Update",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityEmpleado Update(EntityEmpleado oEntityEmpleado);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Delete",
            Method = "DELETE",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityEmpleado Delete(EntityEmpleado oEntityEmpleado);

    }
}
