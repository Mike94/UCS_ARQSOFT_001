using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyGrupo
    {
        private Int32 idGrupo;

        [DataMember]
        public Int32 IDGrupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }

        public KeyGrupo()
        {

        }

        public KeyGrupo(Int32 pIDGrupo)
        {
            this.idGrupo = pIDGrupo;
        }

        public static KeyGrupo Create(IDataReader row)
        {
            return new KeyGrupo(
                DataCreator.CreateInt32(row, "IDGrupo")
            );
        }


        public static KeyGrupo Empty
        {
            get
            {
                return new KeyGrupo(
                    Parameters.Cero);
            }
        }
    }
}
