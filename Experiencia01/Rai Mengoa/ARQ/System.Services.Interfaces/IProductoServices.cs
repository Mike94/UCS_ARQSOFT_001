using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.Services.Contracts
{
    [ServiceContract]
    public interface IProductoServices
    {
        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectByKey",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityProducto SelectByKey(KeyProducto oKeyProducto);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Select/",
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityProducto> Select();

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Insert/",
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityProducto Insert(EntityProducto oEntityProducto);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Update",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityProducto Update(EntityProducto oEntityProducto);

        [OperationContract]
        [WebInvoke
        (UriTemplate = "/SelectPagging/",
        Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped)]
        IList<EntityProductoPaginacion> SelectPagging(ref EntityProductoPaginacion oEntityProductoPaginacion);


    }
}
