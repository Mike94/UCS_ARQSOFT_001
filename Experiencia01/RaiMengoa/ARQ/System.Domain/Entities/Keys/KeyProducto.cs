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
    public class KeyProducto
    {
        private Int32 _IDProducto;

        [DataMember]
        public Int32 IDProducto
        {
            get { return _IDProducto; }
            set { _IDProducto = value; }
        }

        public KeyProducto()
        {
            
        }

        public KeyProducto(Int32 pIDProducto)
        {
            this._IDProducto = pIDProducto;
        }

        public static KeyProducto Create(IDataReader row)
        {
            return new KeyProducto(
                DataCreator.CreateInt32(row, "IDProducto")
            );
        }

        
        public static KeyProducto Empty
        {
            get
            {
                return new KeyProducto(
                    Parameters.UnoNegativo);
            }
        }
    }
}
