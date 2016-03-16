using System;
using System.Data;
using System.Runtime.Serialization;

namespace System.CustomTypes
{
    [DataContract]
    public class CInt64 : BaseType<Int64>
    {
        private CInt64(Object value)
            : base(value)
        {
        }

        [DataMember]
        public static CInt64 Empty
        {
            get
            {
                return new CInt64(null);
            }
        }

        public static CInt64 Create(Int64 value)
        {
            CInt64 Customtype = new CInt64(value);
            return Customtype;
        }

        public static CInt64 Create(object value)
        {
            Int64 newValue = Convert.ToInt64(value);
            CInt64 Customtype = new CInt64(newValue);
            return Customtype;
        }

        public static CInt64 Create(IDataReader row, String name)
        {
            CInt64 Customtype = new CInt64(row[name]);
            return Customtype;
        }
    }
}
