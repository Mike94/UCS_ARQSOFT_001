using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyTienda
    {
        private String codTienda;

        [DataMember]
        public String CodTienda
        {
            get { return codTienda; }
            set { codTienda = value; }
        }

        public KeyTienda()
        {
            
        }

        public KeyTienda(String pCodTienda)
        {
            this.codTienda = pCodTienda;
        }

        public static KeyTienda Create(IDataReader row)
        {
            return new KeyTienda(
                DataCreator.CreateString(row, "CodTienda")
            );
        }

        public static KeyTienda Empty
        {
            get
            {
                return new KeyTienda(
                    Parameters.Vacio);
            }
        }
    }
}
