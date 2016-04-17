using System;
using System.Data;
using System.Runtime.Serialization;

namespace System.CustomTypes
{
    [DataContract]
    public class CInt16 : BaseType<Int16>
    {
        private CInt16(Object value)
            : base(value)
        {
        }

        [DataMember]
        public static CInt16 Empty
        {
            get
            {
                return new CInt16(null);
            }
        }

        public static CInt16 Create(Int16 value)
        {
            CInt16 Customtype = new CInt16(value);
            return Customtype;
        }

        public static CInt16 Create(object value)
        {
            Int16 newValue = Convert.ToInt16(value);
            CInt16 Customtype = new CInt16(newValue);
            return Customtype;
        }

        public static CInt16 Create(IDataReader row, String name)
        {
            CInt16 Customtype = new CInt16(row[name]);
            return Customtype;
        }
    }
}
