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
    public interface IEmpresaServices
    {
        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectByKey",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityEmpresa SelectByKey(KeyEmpresa oKeyEmpresa);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Select/",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityEmpresa> Select(EntityEmpresa oEntityEmpresa);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/SelectTipoEmpresa/",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        IList<EntityTipoEmpresa> SelectTipoEmpresa(EntityTipoEmpresa oEntityEmpresa);

        [OperationContract]
        [WebInvoke
        (UriTemplate = "/SelectPagging/",
        Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped)]
        IList<EntityEmpresaPaginacion> SelectPagging(ref EntityEmpresaPaginacion oEntityEmpresaPaginacion);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Insert/",
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityEmpresa Insert(EntityEmpresa oEntityEmpresa);

        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Update/",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityEmpresa Update(EntityEmpresa oEntityEmpresa);


        [OperationContract]
        [WebInvoke
            (UriTemplate = "/Delete/",
            Method = "DELETE",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        EntityEmpresa Delete(EntityEmpresa oEntityEmpresa);
    }
}
