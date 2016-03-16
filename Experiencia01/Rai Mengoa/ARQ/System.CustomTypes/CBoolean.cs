using System;
using System.Data;
using System.Runtime.Serialization;

namespace System.CustomTypes
{
    [DataContract]
    public class CBoolean : BaseType<Boolean>
    {
        private CBoolean(Object value)
            : base(value)
        {
        }

        [DataMember]
        public static CBoolean Empty
        {
            get
            {
                return new CBoolean(null);
            }
        }

        public static CBoolean Create(Boolean value)
        {
            CBoolean Customtype = new CBoolean(value);
            return Customtype;
        }

        public static CBoolean Create(object value)
        {
            Boolean newValue = Convert.ToBoolean(value);
            CBoolean Customtype = new CBoolean(newValue);
            return Customtype;
        }

        public static CBoolean Create(IDataReader row, String name)
        {
            CBoolean Customtype = new CBoolean(row[name]);
            return Customtype;
        }
    }
}
