using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityEmpresa
    {
        private KeyEmpresa key;
        private String codigoEmpresa;
        private String razonComercial;
        private String razonSocial;
        private String ruc;
        private String telefono;
        private String contacto;
        private String direccion;
        private Int32 idTipoEmpresa;
        private Int32 estado;

        public EntityEmpresa()
        {

        }

        public EntityEmpresa(
           Keys.KeyEmpresa okey,
           String oCodigoEmpresa,
           String oRazonComercial,
           String oRazonSocial,
           String oRuc,
           String oTelefono,
           String oContacto,
           String oDireccion,
           Int32 oIdTipoEmpresa,
           Int32 oEstado)
        {
            this.key = okey;
            this.codigoEmpresa = oCodigoEmpresa;
            this.razonComercial = oRazonComercial;
            this.razonSocial = oRazonSocial;
            this.ruc = oRuc;
            this.telefono = oTelefono;
            this.direccion = oDireccion;
            this.idTipoEmpresa = oIdTipoEmpresa;
            this.estado = oEstado;
        }

        [DataMember]
        public KeyEmpresa Key
        {
            get { return key; }
            set { key = value; }
        }

        [DataMember]
        public String CodigoEmpresa
        {
            get { return codigoEmpresa; }
            set { codigoEmpresa = value; }
        }

        [DataMember]
        public String RazonComercial
        {
            get { return razonComercial; }
            set { razonComercial = value; }
        }

        [DataMember]
        public String RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        [DataMember]
        public String RUC
        {
            get { return ruc; }
            set { ruc = value; }
        }

        [DataMember]
        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [DataMember]
        public String Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }

        [DataMember]
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        [DataMember]
        public Int32 IdTipoEmpresa
        {
            get { return idTipoEmpresa; }
            set { idTipoEmpresa = value; }
        }

        [DataMember]
        public Int32 Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public static EntityEmpresa Create(IDataReader row)
        {
            return new EntityEmpresa(
               Keys.KeyEmpresa.Create(row),
               DataCreator.CreateString(row, "CodigoEmpresa"),
               DataCreator.CreateString(row, "RazonComercial"),
               DataCreator.CreateString(row, "RazonSocial"),
               DataCreator.CreateString(row, "RUC"),
               DataCreator.CreateString(row, "Telefono"),
               DataCreator.CreateString(row, "Contacto"),
               DataCreator.CreateString(row, "Direccion"),
               DataCreator.CreateInt32(row, "IdTipoEmpresa"),
               DataCreator.CreateInt32(row, "Estado"));
        }

        public static EntityEmpresa Empty
        {
            get
            {
                return new EntityEmpresa(
                Keys.KeyEmpresa.Empty,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio, 
                Parameters.Vacio,
                Parameters.Cero,
                Parameters.UnoNegativo);
            }
        }

    }
}
