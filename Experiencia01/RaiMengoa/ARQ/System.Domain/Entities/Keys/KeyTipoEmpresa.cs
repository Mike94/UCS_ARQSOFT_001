using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyTipoEmpresa
    {
        private Int32 idTipoEmpresa;

        [DataMember]
        public Int32 IDTipoEmpresa
        {
            get { return idTipoEmpresa; }
            set { idTipoEmpresa = value; }
        }

        public KeyTipoEmpresa()
        {

        }

        public KeyTipoEmpresa(Int32 pIDTipoEmpresa)
        {
            this.idTipoEmpresa = pIDTipoEmpresa;
        }

        public static KeyTipoEmpresa Create(IDataReader row)
        {
            return new KeyTipoEmpresa(
                DataCreator.CreateInt32(row, "IDTipoEmpresa")
            );
        }


        public static KeyTipoEmpresa Empty
        {
            get
            {
                return new KeyTipoEmpresa(
                    Parameters.Cero);
            }
        }
    }
}
