using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using SGISystem.Domain.Entities.Keys;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityProducto
    {
        private KeyProducto key;
        private String nombre;
        private String descripcionCorta;
        private String descripcionLarga;
        private Int32 cantidadMinimaInventario;
        private Int32 cantidadInventario;
        private Decimal precioUnitario;
        private Int32 idGrupo;
        private Int32 estado;
        
         public EntityProducto()
        {

        }

        public EntityProducto(
            Keys.KeyProducto okey,
            String oNombre,
            String oDescripcionCorta,
            String oDescripcionLarga,
            Int32 oCantidadMinimaInventario,
            Int32 oCantidadInventario,
            Decimal oPrecioUnitario,
            int oIdGrupo,
            int oEstado
            )
        {
            this.key = okey;
            this.nombre = oNombre;
            this.descripcionCorta = oDescripcionCorta;
            this.descripcionLarga = oDescripcionLarga;
            this.cantidadMinimaInventario = oCantidadMinimaInventario;
            this.cantidadInventario = oCantidadInventario;
            this.precioUnitario = oPrecioUnitario;
            this.idGrupo = oIdGrupo;
            this.estado = oEstado;
        }

        [DataMember]
        public KeyProducto Key
        {
            get { return key; }
            set { key = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return nombre ; }
            set { nombre = value; }
        }
        [DataMember]
        public String DescripcionCorta 
        {
            get { return descripcionCorta; }
            set { descripcionCorta = value;}
        }

        [DataMember]
        public String DescripcionLarga
        {
            get { return descripcionLarga; }
            set { descripcionLarga = value; }
        }
        [DataMember]
        public Int32 CantidadMinimaInventario
        {
            get { return cantidadMinimaInventario ; }
            set { cantidadMinimaInventario = value; }
        }

        [DataMember]
        public Int32 Cantidadinventario
        {
            get { return cantidadInventario; }
            set { cantidadInventario = value; }
        }

        [DataMember]
        public Decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }
        [DataMember]
        public Int32 IdGrupo
        {
            get { return idGrupo ; }
            set { idGrupo = value; }
        }
        [DataMember]
        public Int32 Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public static EntityProducto Create(IDataReader fila)
        {
            return new EntityProducto(
                Keys.KeyProducto.Create(fila),
                DataCreator.CreateString(fila, "NombreProducto"),
                DataCreator.CreateString(fila, "DescripcionCorta"),
                DataCreator.CreateString(fila, "DescripcionLarga"),
                DataCreator.CreateInt32(fila, "CantidadMinimaInventario"),
                DataCreator.CreateInt32(fila, "CantidadInventario"),
                DataCreator.CreateDecimal(fila, "PrecioUnitario"),
                DataCreator.CreateInt32(fila, "IdGrupo"),
                DataCreator.CreateInt32(fila, "Estado"));
        }


        public static EntityProducto Empty
        {
            get
            {
                return new EntityProducto(
                Keys.KeyProducto.Empty,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Cero,
                Parameters.Cero,
                Parameters.Cero,
                Parameters.Cero,
                Parameters.UnoNegativo);
            }
        }
    }
}
