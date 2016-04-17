using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyEmpleado
    {
        private Int32 idEmpleado;

        [DataMember]
        public Int32 IDEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public KeyEmpleado()
        {

        }
        public KeyEmpleado(Int32 pidEmpleado)
        {
            this.idEmpleado = pidEmpleado;
        }

        public static KeyEmpleado Create(IDataReader row)
        {
            return new KeyEmpleado(
                DataCreator.CreateInt32(row, "IDEmpleado")
            );
        }

        
        public static KeyEmpleado Empty
        {
            get
            {
                return new KeyEmpleado(
                    Parameters.Cero);
            }
        }
    }
}
