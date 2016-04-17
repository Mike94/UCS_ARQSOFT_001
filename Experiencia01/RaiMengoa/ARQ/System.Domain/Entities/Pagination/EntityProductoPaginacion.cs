using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.Domain.Entities
{
     [DataContract]
    public class EntityProductoPaginacion : EntityProducto
    {
         public EntityProductoPaginacion()
         {

         }

         public EntityProductoPaginacion(
            Keys.KeyProducto okey,
            String oNombre,
            String oDescripcionCorta,
            String oDescripcionLarga,
            int oCantidadMinimainventario,
            int oCantidadInventario,
            Decimal oPrecioUnitario,
            int oIdGrupo,
            int oestado,
            String oGrupoNombre,
            String oEstadoNombre,
            EntityPaginacion oEntityPaginacion)
             :base(
            okey,
            oNombre,
            oDescripcionCorta,
            oDescripcionLarga,
            oCantidadMinimainventario,
            oCantidadInventario,
            oPrecioUnitario,
            oIdGrupo,
            oestado
            )
        {


            this.GrupoNombre = oGrupoNombre;
            this.EstadoNombre = oEstadoNombre;
             
            this.entityPaginacion = oEntityPaginacion;
        }
         private EntityPaginacion entityPaginacion;

         [DataMember]
         public EntityPaginacion EntityPaginacion
         {
             get { return entityPaginacion; }
             set { entityPaginacion = value; }
         }

         private String grupoNombre;

         [DataMember]
         public String GrupoNombre
         {
             get { return grupoNombre; }
             set { grupoNombre = value; }
         }

         private String estadonombre;

         [DataMember]
         public String EstadoNombre
         {
             get { return estadonombre; }
             set { estadonombre = value; }
         }
         public static EntityProductoPaginacion CreatePag(IDataReader row)
         {
             return new EntityProductoPaginacion(
                Keys.KeyProducto.Create(row),
                 DataCreator.CreateString(row, "NombreProducto"),
                 DataCreator.CreateString(row, "DescripcionCorta"),
                 DataCreator.CreateString(row, "DescripcionLarga"),
                 DataCreator.CreateInt32(row, "CantidadMinimainventario"),
                 DataCreator.CreateInt32(row, "CantidadInventario"),
                 DataCreator.CreateDecimal(row, "PrecioUnitario"),
                 DataCreator.CreateInt32(row, "IdGrupo"),
                 DataCreator.CreateInt32(row, "Estado"),
                 DataCreator.CreateString(row, "GrupoNombre"),
                 DataCreator.CreateString(row, "EstadoNombre"),
                 null);
         }
         public static EntityProductoPaginacion EmptyPag
         {
             get
             {
                 return new EntityProductoPaginacion(
                     Keys.KeyProducto.Empty,
                     Parameters.Vacio,
                     Parameters.Vacio,
                     Parameters.Vacio,
                     Parameters.Cero,
                     Parameters.Cero,
                     Parameters.Cero,
                     Parameters.Cero,
                     Parameters.Cero,
                     Parameters.Vacio,
                     Parameters.Vacio,
                     null);
             }
         }

       

    }
}
