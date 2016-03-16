using System;
using System.Data;
using System.Runtime.Serialization;

namespace System.CustomTypes
{
    [DataContract]
    public class CDecimal : BaseType<Decimal>
    {
        private CDecimal(Object value)
            : base(value)
        {
        }

        [DataMember]
        public static CDecimal Empty
        {
            get
            {
                return new CDecimal(null);
            }
        }

        public static CDecimal Create(Decimal value)
        {
            CDecimal Customtype = new CDecimal(value);
            return Customtype;
        }

        public static CDecimal Create(object value)
        {
            Decimal newValue = Convert.ToDecimal(value);
            CDecimal Customtype = new CDecimal(newValue);
            return Customtype;
        }

        public static CDecimal Create(IDataReader row, String name)
        {
            CDecimal Customtype = new CDecimal(row[name]);
            return Customtype;
        }
    }
}
