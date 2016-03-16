using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyCargo
    {
        private Int32 idCargo;

        [DataMember]
        public Int32 IDCargo
        {
            get { return idCargo; }
            set { idCargo = value; }
        }

        public KeyCargo()
        {

        }

        public KeyCargo(Int32 oIDCargo)
        {
            this.idCargo = oIDCargo;
        }

        public static KeyCargo Create(IDataReader row)
        {
            return new KeyCargo(
                DataCreator.CreateInt32(row, "IDCargo")
            );
        }


        public static KeyCargo Empty
        {
            get
            {
                return new KeyCargo(
                    Parameters.Cero);
            }
        }
    }
}
