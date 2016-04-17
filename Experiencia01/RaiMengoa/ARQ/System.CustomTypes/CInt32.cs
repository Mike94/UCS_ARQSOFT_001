using System;
using System.Data;
using System.Runtime.Serialization;

namespace System.CustomTypes
{
    [DataContract]
    public class CInt32 : BaseType<Int32>
    {
        private CInt32(Object value)
            : base(value)
        {
        }

        [DataMember]
        public static CInt32 Empty
        {
            get
            {
                return new CInt32(null);
            }
        }

        public static CInt32 Create(Int32 value)
        {
            CInt32 Customtype = new CInt32(value);
            return Customtype;
        }

        public static CInt32 Create(object value)
        {
            Int32 newValue = Convert.ToInt32(value);
            CInt32 Customtype = new CInt32(newValue);
            return Customtype;
        }

        public static CInt32 Create(IDataReader row, String name)
        {
            CInt32 Customtype = new CInt32(row[name]);
            return Customtype;
        }
    }
}
