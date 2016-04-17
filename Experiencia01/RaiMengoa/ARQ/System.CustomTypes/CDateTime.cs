using System;
using System.Data;
using System.Runtime.Serialization;

namespace System.CustomTypes
{
    [DataContract]
    public class CDateTime : BaseType<DateTime>
    {
        private CDateTime(Object value)
            : base(value)
        {

        }

        [DataMember]
        public static CDateTime Empty
        {
            get
            {
                return new CDateTime(null);
            }
        }

        public static CDateTime Now
        {
            get
            {
                return new CDateTime(DateTime.Now);
            }
        }

        public String Formatted
        {
            get
            {
                if (!base.IsNull)
                {
                    return String.Format("{0:dd/MM/yyyy}", Value);
                }
                return "";
            }
        }
        
        public static CDateTime Create(DateTime value)
        {
            CDateTime Customtype = new CDateTime(value);
            return Customtype;
        }

        public static CDateTime Create(object value)
        {
            DateTime newValue = Convert.ToDateTime(value);
            CDateTime Customtype = new CDateTime(newValue);
            return Customtype;
        }

        public static CDateTime Create(IDataReader row, String name)
        {
            CDateTime Customtype = new CDateTime(row[name]);
            return Customtype;
        }
    }
}