using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using SGISystem.Domain.Entities.Keys;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityEmpleado
    {
        private KeyEmpleado key;
        private String codTienda;
        private String nombres;
        private String apellidos;
        private DateTime fechaNacimiento;
        private String dni;
        private Int32 idCargo;
        private Char sexo;
        private Char estadoCivil;
        private Int32 estado;
        

        public EntityEmpleado()
        {

        }

        public EntityEmpleado(
           Keys.KeyEmpleado oKey,
           String oCodTienda,
           String oNombres,
           String oApellidos,
           DateTime oFechaNacimiento,
           String oDni,
           Int32 oIdCargo,
           Char oSexo,
           Char oEstadoCivil,
           Int32 oEstado)
        {
            this.key = oKey;
            this.codTienda = oCodTienda;
            this.nombres = oNombres;
            this.apellidos = oApellidos;
            this.fechaNacimiento = oFechaNacimiento;
            this.dni = oDni;
            this.idCargo = oIdCargo;
            this.sexo = oSexo;
            this.estadoCivil = oEstadoCivil;
            this.estado = oEstado;
        }

        [DataMember]
        public KeyEmpleado Key
        {
            get { return key; }
            set { key = value; }
        }

        [DataMember]
        public String CodTienda
        {
            get { return codTienda; }
            set { codTienda = value; }
        }

        [DataMember]
        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        [DataMember]
        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        [DataMember]
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        [DataMember]
        public String DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        [DataMember]
        public Int32 IdCargo
        {
            get { return idCargo; }
            set { idCargo = value; }
        }

        [DataMember]
        public Char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        [DataMember]
        public Char EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        [DataMember]
        public Int32 Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public static EntityEmpleado Create(IDataReader row)
        {
            return new EntityEmpleado(
                Keys.KeyEmpleado.Create(row),
                DataCreator.CreateString(row, "CodTienda"),
                DataCreator.CreateString(row, "Nombres"),
                DataCreator.CreateString(row, "Apellidos"),
                DataCreator.CreateDatetime(row, "FechaNacimiento"),
                DataCreator.CreateString(row, "DNI"),
                DataCreator.CreateInt32(row, "IdCargo"),
                DataCreator.CreateChar(row, "Sexo"),
                DataCreator.CreateChar(row, "EstadoCivil"),
                DataCreator.CreateInt32(row, "Estado"));
        }


        public static EntityEmpleado Empty
        {
            get { return new EntityEmpleado(
                Keys.KeyEmpleado.Empty,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.DtUnoUnoUno,
                Parameters.Vacio,
                Parameters.Cero,
                Parameters.VacioChar,
                Parameters.VacioChar,
                Parameters.UnoNegativo
                );
            }
        }
        
    }
}
