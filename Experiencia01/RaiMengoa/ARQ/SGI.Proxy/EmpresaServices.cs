﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGI.Proxy.Services.EmpresaServices
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KeyEmpresa", Namespace="http://schemas.datacontract.org/2004/07/SGISystem.Domain.Entities.Keys")]
    public partial class KeyEmpresa : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IDEmpresaField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDEmpresa
        {
            get
            {
                return this.IDEmpresaField;
            }
            set
            {
                this.IDEmpresaField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityEmpresa", Namespace="http://schemas.datacontract.org/2004/07/SGISystem.Domain.Entities")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SGI.Proxy.Services.EmpresaServices.EntityEmpresaPaginacion))]
    public partial class EntityEmpresa : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CodigoEmpresaField;
        
        private string ContactoField;
        
        private string DireccionField;
        
        private int EstadoField;
        
        private int IdTipoEmpresaField;
        
        private SGI.Proxy.Services.EmpresaServices.KeyEmpresa KeyField;
        
        private string RUCField;
        
        private string RazonComercialField;
        
        private string RazonSocialField;
        
        private string TelefonoField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoEmpresa
        {
            get
            {
                return this.CodigoEmpresaField;
            }
            set
            {
                this.CodigoEmpresaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contacto
        {
            get
            {
                return this.ContactoField;
            }
            set
            {
                this.ContactoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion
        {
            get
            {
                return this.DireccionField;
            }
            set
            {
                this.DireccionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Estado
        {
            get
            {
                return this.EstadoField;
            }
            set
            {
                this.EstadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdTipoEmpresa
        {
            get
            {
                return this.IdTipoEmpresaField;
            }
            set
            {
                this.IdTipoEmpresaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SGI.Proxy.Services.EmpresaServices.KeyEmpresa Key
        {
            get
            {
                return this.KeyField;
            }
            set
            {
                this.KeyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RUC
        {
            get
            {
                return this.RUCField;
            }
            set
            {
                this.RUCField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RazonComercial
        {
            get
            {
                return this.RazonComercialField;
            }
            set
            {
                this.RazonComercialField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RazonSocial
        {
            get
            {
                return this.RazonSocialField;
            }
            set
            {
                this.RazonSocialField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono
        {
            get
            {
                return this.TelefonoField;
            }
            set
            {
                this.TelefonoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityEmpresaPaginacion", Namespace="http://schemas.datacontract.org/2004/07/SGISystem.Domain.Entities")]
    public partial class EntityEmpresaPaginacion : SGI.Proxy.Services.EmpresaServices.EntityEmpresa
    {
        
        private SGI.Proxy.Services.EmpresaServices.EntityPaginacion EntityPaginacionField;
        
        private string EstadoNombreField;
        
        private string TipoEmpresaNombreField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SGI.Proxy.Services.EmpresaServices.EntityPaginacion EntityPaginacion
        {
            get
            {
                return this.EntityPaginacionField;
            }
            set
            {
                this.EntityPaginacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstadoNombre
        {
            get
            {
                return this.EstadoNombreField;
            }
            set
            {
                this.EstadoNombreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoEmpresaNombre
        {
            get
            {
                return this.TipoEmpresaNombreField;
            }
            set
            {
                this.TipoEmpresaNombreField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityPaginacion", Namespace="http://schemas.datacontract.org/2004/07/SGISystem.Domain.Entities")]
    public partial class EntityPaginacion : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int PageIndexField;
        
        private int RowCountField;
        
        private int RowsPerPageField;
        
        private string SortDirField;
        
        private string SortTypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageIndex
        {
            get
            {
                return this.PageIndexField;
            }
            set
            {
                this.PageIndexField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RowCount
        {
            get
            {
                return this.RowCountField;
            }
            set
            {
                this.RowCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RowsPerPage
        {
            get
            {
                return this.RowsPerPageField;
            }
            set
            {
                this.RowsPerPageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SortDir
        {
            get
            {
                return this.SortDirField;
            }
            set
            {
                this.SortDirField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SortType
        {
            get
            {
                return this.SortTypeField;
            }
            set
            {
                this.SortTypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityTipoEmpresa", Namespace="http://schemas.datacontract.org/2004/07/SGISystem.Domain.Entities")]
    public partial class EntityTipoEmpresa : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int EstadoField;
        
        private SGI.Proxy.Services.EmpresaServices.KeyTipoEmpresa KeyField;
        
        private string NombreTipoField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Estado
        {
            get
            {
                return this.EstadoField;
            }
            set
            {
                this.EstadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SGI.Proxy.Services.EmpresaServices.KeyTipoEmpresa Key
        {
            get
            {
                return this.KeyField;
            }
            set
            {
                this.KeyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreTipo
        {
            get
            {
                return this.NombreTipoField;
            }
            set
            {
                this.NombreTipoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KeyTipoEmpresa", Namespace="http://schemas.datacontract.org/2004/07/SGISystem.Domain.Entities.Keys")]
    public partial class KeyTipoEmpresa : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IDTipoEmpresaField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDTipoEmpresa
        {
            get
            {
                return this.IDTipoEmpresaField;
            }
            set
            {
                this.IDTipoEmpresaField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SGI.Proxy.Services.EmpresaServices.IEmpresaServices")]
    public interface IEmpresaServices
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/SelectByKey", ReplyAction="http://tempuri.org/IEmpresaServices/SelectByKeyResponse")]
        SGI.Proxy.Services.EmpresaServices.EntityEmpresa SelectByKey(SGI.Proxy.Services.EmpresaServices.KeyEmpresa oKeyEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/SelectByKey", ReplyAction="http://tempuri.org/IEmpresaServices/SelectByKeyResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityEmpresa> SelectByKeyAsync(SGI.Proxy.Services.EmpresaServices.KeyEmpresa oKeyEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/Select", ReplyAction="http://tempuri.org/IEmpresaServices/SelectResponse")]
        SGI.Proxy.Services.EmpresaServices.EntityEmpresa[] Select(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/Select", ReplyAction="http://tempuri.org/IEmpresaServices/SelectResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityEmpresa[]> SelectAsync(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/SelectTipoEmpresa", ReplyAction="http://tempuri.org/IEmpresaServices/SelectTipoEmpresaResponse")]
        SGI.Proxy.Services.EmpresaServices.EntityTipoEmpresa[] SelectTipoEmpresa(SGI.Proxy.Services.EmpresaServices.EntityTipoEmpresa oEntityEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/SelectTipoEmpresa", ReplyAction="http://tempuri.org/IEmpresaServices/SelectTipoEmpresaResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityTipoEmpresa[]> SelectTipoEmpresaAsync(SGI.Proxy.Services.EmpresaServices.EntityTipoEmpresa oEntityEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/SelectPagging", ReplyAction="http://tempuri.org/IEmpresaServices/SelectPaggingResponse")]
        SGI.Proxy.Services.EmpresaServices.SelectPaggingResponse SelectPagging(SGI.Proxy.Services.EmpresaServices.SelectPaggingRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/SelectPagging", ReplyAction="http://tempuri.org/IEmpresaServices/SelectPaggingResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.SelectPaggingResponse> SelectPaggingAsync(SGI.Proxy.Services.EmpresaServices.SelectPaggingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/Insert", ReplyAction="http://tempuri.org/IEmpresaServices/InsertResponse")]
        SGI.Proxy.Services.EmpresaServices.EntityEmpresa Insert(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/Insert", ReplyAction="http://tempuri.org/IEmpresaServices/InsertResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityEmpresa> InsertAsync(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/Update", ReplyAction="http://tempuri.org/IEmpresaServices/UpdateResponse")]
        SGI.Proxy.Services.EmpresaServices.EntityEmpresa Update(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/Update", ReplyAction="http://tempuri.org/IEmpresaServices/UpdateResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityEmpresa> UpdateAsync(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/Delete", ReplyAction="http://tempuri.org/IEmpresaServices/DeleteResponse")]
        SGI.Proxy.Services.EmpresaServices.EntityEmpresa Delete(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaServices/Delete", ReplyAction="http://tempuri.org/IEmpresaServices/DeleteResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityEmpresa> DeleteAsync(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectPagging", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectPaggingRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SGI.Proxy.Services.EmpresaServices.EntityEmpresaPaginacion oEntityEmpresaPaginacion;
        
        public SelectPaggingRequest()
        {
        }
        
        public SelectPaggingRequest(SGI.Proxy.Services.EmpresaServices.EntityEmpresaPaginacion oEntityEmpresaPaginacion)
        {
            this.oEntityEmpresaPaginacion = oEntityEmpresaPaginacion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectPaggingResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectPaggingResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SGI.Proxy.Services.EmpresaServices.EntityEmpresaPaginacion[] SelectPaggingResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public SGI.Proxy.Services.EmpresaServices.EntityEmpresaPaginacion oEntityEmpresaPaginacion;
        
        public SelectPaggingResponse()
        {
        }
        
        public SelectPaggingResponse(SGI.Proxy.Services.EmpresaServices.EntityEmpresaPaginacion[] SelectPaggingResult, SGI.Proxy.Services.EmpresaServices.EntityEmpresaPaginacion oEntityEmpresaPaginacion)
        {
            this.SelectPaggingResult = SelectPaggingResult;
            this.oEntityEmpresaPaginacion = oEntityEmpresaPaginacion;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmpresaServicesChannel : SGI.Proxy.Services.EmpresaServices.IEmpresaServices, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpresaServicesClient : System.ServiceModel.ClientBase<SGI.Proxy.Services.EmpresaServices.IEmpresaServices>, SGI.Proxy.Services.EmpresaServices.IEmpresaServices
    {
        
        public EmpresaServicesClient()
        {
        }
        
        public EmpresaServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public EmpresaServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public EmpresaServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public EmpresaServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public SGI.Proxy.Services.EmpresaServices.EntityEmpresa SelectByKey(SGI.Proxy.Services.EmpresaServices.KeyEmpresa oKeyEmpresa)
        {
            return base.Channel.SelectByKey(oKeyEmpresa);
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityEmpresa> SelectByKeyAsync(SGI.Proxy.Services.EmpresaServices.KeyEmpresa oKeyEmpresa)
        {
            return base.Channel.SelectByKeyAsync(oKeyEmpresa);
        }
        
        public SGI.Proxy.Services.EmpresaServices.EntityEmpresa[] Select(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa)
        {
            return base.Channel.Select(oEntityEmpresa);
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityEmpresa[]> SelectAsync(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa)
        {
            return base.Channel.SelectAsync(oEntityEmpresa);
        }
        
        public SGI.Proxy.Services.EmpresaServices.EntityTipoEmpresa[] SelectTipoEmpresa(SGI.Proxy.Services.EmpresaServices.EntityTipoEmpresa oEntityEmpresa)
        {
            return base.Channel.SelectTipoEmpresa(oEntityEmpresa);
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityTipoEmpresa[]> SelectTipoEmpresaAsync(SGI.Proxy.Services.EmpresaServices.EntityTipoEmpresa oEntityEmpresa)
        {
            return base.Channel.SelectTipoEmpresaAsync(oEntityEmpresa);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SGI.Proxy.Services.EmpresaServices.SelectPaggingResponse SGI.Proxy.Services.EmpresaServices.IEmpresaServices.SelectPagging(SGI.Proxy.Services.EmpresaServices.SelectPaggingRequest request)
        {
            return base.Channel.SelectPagging(request);
        }
        
        public SGI.Proxy.Services.EmpresaServices.EntityEmpresaPaginacion[] SelectPagging(ref SGI.Proxy.Services.EmpresaServices.EntityEmpresaPaginacion oEntityEmpresaPaginacion)
        {
            SGI.Proxy.Services.EmpresaServices.SelectPaggingRequest inValue = new SGI.Proxy.Services.EmpresaServices.SelectPaggingRequest();
            inValue.oEntityEmpresaPaginacion = oEntityEmpresaPaginacion;
            SGI.Proxy.Services.EmpresaServices.SelectPaggingResponse retVal = ((SGI.Proxy.Services.EmpresaServices.IEmpresaServices)(this)).SelectPagging(inValue);
            oEntityEmpresaPaginacion = retVal.oEntityEmpresaPaginacion;
            return retVal.SelectPaggingResult;
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.SelectPaggingResponse> SelectPaggingAsync(SGI.Proxy.Services.EmpresaServices.SelectPaggingRequest request)
        {
            return base.Channel.SelectPaggingAsync(request);
        }
        
        public SGI.Proxy.Services.EmpresaServices.EntityEmpresa Insert(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa)
        {
            return base.Channel.Insert(oEntityEmpresa);
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityEmpresa> InsertAsync(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa)
        {
            return base.Channel.InsertAsync(oEntityEmpresa);
        }
        
        public SGI.Proxy.Services.EmpresaServices.EntityEmpresa Update(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa)
        {
            return base.Channel.Update(oEntityEmpresa);
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityEmpresa> UpdateAsync(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa)
        {
            return base.Channel.UpdateAsync(oEntityEmpresa);
        }
        
        public SGI.Proxy.Services.EmpresaServices.EntityEmpresa Delete(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa)
        {
            return base.Channel.Delete(oEntityEmpresa);
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.EmpresaServices.EntityEmpresa> DeleteAsync(SGI.Proxy.Services.EmpresaServices.EntityEmpresa oEntityEmpresa)
        {
            return base.Channel.DeleteAsync(oEntityEmpresa);
        }
    }
}
