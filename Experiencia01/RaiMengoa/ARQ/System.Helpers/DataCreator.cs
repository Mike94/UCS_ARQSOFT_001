using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD = System.Data;

namespace SGISystem.Helpers
{
    public class DataCreator
    {
        public static Int32 CreateInt32(SD.IDataReader fila, String nombre)
        {
            if (null != fila[nombre])
	        {
		        Int32 value;
                Boolean tryConverter = Int32.TryParse(fila[nombre].ToString(), out value);
                return (tryConverter) ? value : 0;
	        } 
            return 0;
        }

        public static Int32 CreateInt32(Object objeto)
        {
            if (null != objeto)
            {
                String newObjeto = (String) objeto;
                Int32 value;
                Boolean tryConverter = Int32.TryParse(newObjeto, out value);
                return (tryConverter) ? value : 0;
            }
            return 0;
        }

        public static String CreateString(SD.IDataReader fila, String nombre)
        {
            if (null != fila[nombre])
	        {
                String value = fila[nombre].ToString();
                return (value != null) ? value : "";
            }
            return "";
        }

        public static Char CreateChar(SD.IDataReader fila, String nombre)
        {
            if (null != fila[nombre])
            {
                Char value = ' ';
                Boolean tryConverter = Char.TryParse(fila[nombre].ToString(), out value);
                return (tryConverter) ? value : ' ';
            }
            return (Char) ' ';
        }

        //Creacion Euler
        public static Decimal  CreateDecimal(SD.IDataReader fila, String nombre)
        {
            if (null != fila[nombre])
            {
                Decimal value;
                Boolean tryConverter = Decimal.TryParse(fila[nombre].ToString(), out value);
                return (tryConverter) ? value : 0;
            }
            return 0;
        }

        //fin Creacion Euler

        public static DateTime CreateDatetime(SD.IDataReader fila, String nombre)
        {
            if (null != fila[nombre])
            {
                DateTime value;
                Boolean tryConverter = DateTime.TryParse(fila[nombre].ToString(), out value);
                return (tryConverter) ? value : new DateTime(1,1,1);
            }
            return new DateTime(1,1,1);
        }

        public static Boolean CreateBoolean(SD.IDataReader fila, String nombre)
        {
            if (null != fila[nombre])
            {
                Boolean value;
                Boolean tryConverter = Boolean.TryParse(fila[nombre].ToString(), out value);
                return (tryConverter) ? value : false;
            }
            return false;
        }
    }
}
