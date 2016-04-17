using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityEmpleadoPaginacion : EntityEmpleado
    {
        public EntityEmpleadoPaginacion()
        {
        }

        public EntityEmpleadoPaginacion(
           Keys.KeyEmpleado oKey,
           String oCodTienda,
           String oNombres,
           String oApellidos,
           DateTime oFechaNacimiento,
           String oDni,
           Int32 oIdCargo,
           Char oSexo,
           Char oEstadoCivil,
           Int32 oEstado,
           String oSexoNombre,
           String oEstadoCivilNombre,
           String oEstadoNombre,
           String oNombreCargo,
           String oNombreTienda,
           EntityPaginacion oEntityPaginacion)
            : base
            (oKey, 
            oCodTienda, 
            oNombres, 
            oApellidos, 
            oFechaNacimiento, 
            oDni, 
            oIdCargo, 
            oSexo, 
            oEstadoCivil, 
            oEstado)
        {
            this.sexoNombre = oSexoNombre;
            this.estadoCivilNombre = oEstadoCivilNombre;
            this.estadoNombre = oEstadoNombre;
            this.nombreCargo = oNombreCargo;
            this.nombreTienda = oNombreTienda;
            this.entityPaginacion = oEntityPaginacion;
        }

        private EntityPaginacion entityPaginacion;

        [DataMember]
        public EntityPaginacion EntityPaginacion
        {
            get { return entityPaginacion; }
            set { entityPaginacion = value; }
        }

        private String estadoNombre;

        [DataMember]
        public String EstadoNombre
        {
            get { return estadoNombre; }
            set { estadoNombre = value; }
        }

        private String sexoNombre;

        [DataMember]
        public String SexoNombre
        {
            get { return sexoNombre; }
            set { sexoNombre = value; }
        }

        private String estadoCivilNombre;

        [DataMember]
        public String EstadoCivilNombre
        {
            get { return estadoCivilNombre; }
            set { estadoCivilNombre = value; }
        }

        private String nombreCargo;

        [DataMember]
        public String NombreCargo
        {
            get { return nombreCargo; }
            set { nombreCargo = value; }
        }

        private String nombreTienda;

        [DataMember]
        public String NombreTienda
        {
            get { return nombreTienda; }
            set { nombreTienda = value; }
        }


        public static EntityEmpleadoPaginacion CreatePag(IDataReader row)
        {
            return new EntityEmpleadoPaginacion(
                Keys.KeyEmpleado.Create(row),
                DataCreator.CreateString(row, "CodTienda"),
                DataCreator.CreateString(row, "Nombres"),
                DataCreator.CreateString(row, "Apellidos"),
                DataCreator.CreateDatetime(row, "FechaNacimiento"),
                DataCreator.CreateString(row, "DNI"),
                DataCreator.CreateInt32(row, "IdCargo"),

                DataCreator.CreateChar(row, "Sexo"),
                DataCreator.CreateChar(row, "EstadoCivil"),
                DataCreator.CreateInt32(row, "Estado"),

                DataCreator.CreateString(row, "SexoNombre"),
                DataCreator.CreateString(row, "EstadoCivilNombre"),
                DataCreator.CreateString(row, "EstadoNombre"),
                DataCreator.CreateString(row, "NombreCargo"),
                DataCreator.CreateString(row, "NombreTienda"),
                null);
        }

        public static EntityEmpleadoPaginacion EmptyPag
        {
            get
            {
                return new EntityEmpleadoPaginacion(
                    Keys.KeyEmpleado.Empty,
                    Parameters.Vacio,
                    Parameters.Vacio,
                    Parameters.Vacio,
                    Parameters.DtUnoUnoUno,
                    Parameters.Vacio,
                    Parameters.Cero,
                    
                    Parameters.VacioChar,
                    Parameters.VacioChar,
                    Parameters.UnoNegativo,

                    Parameters.Vacio,
                    Parameters.Vacio,
                    Parameters.Vacio,
                    Parameters.Vacio,
                    Parameters.Vacio,
                    null);
            }
        }
        
    }
}
