using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyEmpresa
    {
        private Int32 _IDEmpresa;

        [DataMember]
        public Int32 IDEmpresa
        {
            get { return _IDEmpresa; }
            set { _IDEmpresa = value; }
        }

        public KeyEmpresa()
        {

        }
        public KeyEmpresa(Int32 oIDEmpresa)
        {
            this._IDEmpresa = oIDEmpresa;
        }

        public static KeyEmpresa Create(IDataReader row)
        {
            return new KeyEmpresa(
                DataCreator.CreateInt32(row, "IDEmpresa")
            );
        }


        public static KeyEmpresa Empty
        {
            get
            {
                return new KeyEmpresa(
                    Parameters.Cero);
            }
        }
    }
}
