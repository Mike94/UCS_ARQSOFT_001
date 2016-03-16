using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.Reporting.WebForms;
using System.Data;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using SGI.Proxy.Services.PedidoServices;

namespace SGI.MVCCliente.Helpers
{
    public class GeneratePDF
    {
        public void CreatePDF(string FileName, string DataSourceName, List<EntityDetallePedido> oDataSource, HttpResponseBase Response)
        {
            var oDataSourceNew = oDataSource.
                    Select(n => new
                    {
                        Producto = n.Key.IDProducto.ToString(),
                        PrecioUnitario = "0",
                        Cantidad = n.Cantidad
                    });

            ReportDataSource rds = new ReportDataSource(DataSourceName, oDataSourceNew.ToArray());

            //ReportExecutionService rsExcel = new ReportExecutionService();

            Warning[] warnings;
            string[] streamIds;
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;

            ReportViewer viewer = new ReportViewer();
            viewer.ProcessingMode = ProcessingMode.Remote;
            PermissionSet permissions = new PermissionSet(PermissionState.None);
            permissions.AddPermission(new FileIOPermission(PermissionState.Unrestricted));
            permissions.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));

            viewer.LocalReport.SetBasePermissionsForSandboxAppDomain(permissions);

            Assembly asm = Assembly.Load(Assembly.GetExecutingAssembly().FullName);
            AssemblyName asm_name = asm.GetName();
            viewer.LocalReport.AddFullTrustModuleInSandboxAppDomain(new StrongName(new StrongNamePublicKeyBlob(asm_name.GetPublicKeyToken()), asm_name.Name, asm_name.Version));
            viewer.LocalReport.ReportPath = "Reporte/VistaPrevia/" + FileName + ".rdlc";
            
            //List<ReportParameter> lstParameter = new List<ReportParameter>();
            //foreach (var item in ArrayReportParameter)
            //{
            //    ReportParameter parameter = new ReportParameter(item.Split(',')[0].ToString(), item.Split(',')[1].ToString());
            //    lstParameter.Add(parameter);
            //}
            //if (lstParameter.Count() > 0)
            //    viewer.LocalReport.SetParameters(lstParameter);

            viewer.LocalReport.DataSources.Add(rds);

            //byte[] bytes = viewer.LocalReport.Render("Excel",string.Empty, out mimeType, out encoding, out extension, out streamIds, out warnings);
            byte[] bytes = viewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamIds, out warnings);

            Response.Buffer = true;
            Response.Clear();
            Response.ContentType = mimeType;
            Response.AddHeader("content-disposition", "attachment; filename=" + FileName + "." + extension);
            Response.BinaryWrite(bytes);
            //Response.Flush();
        }
    }
}